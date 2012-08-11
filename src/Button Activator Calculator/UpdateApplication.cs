using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using System.Deployment.Application;

namespace Button_Activator_Calculator
{
    class UpdateApplication
    {
        // Method for URL opening
        public void openURL(string url)
        {
            try { Process.Start(url); }
            catch (Exception e)
            {
                // System.ComponentModel.Win32Exception is a known exception that occurs when Firefox is default browser.  
                // It actually opens the browser but STILL throws this exception so we can just ignore it.
                // If not this exception, then attempt to open the URL in IE instead.
                if (e.GetType().ToString() != "System.ComponentModel.Win32Exception")
                {
                    // Sometimes throws exception so we have to just ignore
                    // This is a common .NET bug that no one online really has a great reason for
                    // so now we just need to try to open the URL using IE if we can.
                    try
                    {
                        ProcessStartInfo startInfo = new ProcessStartInfo("IExplore.exe", url);
                        Process.Start(startInfo);
                        startInfo = null;
                    }
                    catch (Exception e2)
                    {
                        MessageBox.Show("An error has been encountered opening the browser. Please report this " +
                                        "error to the developer.\n\nError: " + e2, "Browser Failed to Open");
                    }
                }
            }
        }

        public void InstallUpdateSyncWithInfo(int x)
        {
            /**
             * The int x argument is the method by which this will check for updates.
             *     0 - Silent update check, only notifys if there is an update
             *     1 - Check with notification if there is no update or valid deployment
             *     2 - Check only for stable releases
            **/

            UpdateCheckInfo info = null;

            if (ApplicationDeployment.IsNetworkDeployed)
            {
                ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;

                try { info = ad.CheckForDetailedUpdate(); }
                catch (DeploymentDownloadException dde)
                {
                    MessageBox.Show("The new version of the application cannot be downloaded at this time." +
                                    "\n\nPlease check your network connection, or try again later. Error: " +
                                    dde.Message, "Update Download Failed");
                    return;
                }
                catch (InvalidDeploymentException ide)
                {
                    MessageBox.Show("Cannot check for a new version of the application. " +
                                    "The deployment is corrupt. " +
                                    "Please redeploy the application and try again. Error: " +
                                    ide.Message, "Could Not Check For Updates");
                    return;
                }
                catch (InvalidOperationException ioe)
                {
                    MessageBox.Show("This application cannot be updated. " +
                                    "It is likely not a ClickOnce deployed application. Error: " +
                                    ioe.Message, "Application Update Failed");
                    return;
                }

                if (info.UpdateAvailable && info.AvailableVersion.Build > 99
                    && info.AvailableVersion.Revision < 101 && x != 2) // If the update is a beta release
                {
                    /**
                     * Here is the processing for beta releases. Since MSVS doesn't let you set a beta number,
                     * betas will have build numbers of 100.   ----->   major.minor.build.revision
                     * To give a beta without a build number, just put the beta number in the revision and
                     * keep the minor number one lower than it needs to be, that way you can do a release update later.
                     * "2.1.100.3" will display as "2.2b3". If you want to include a build number in your
                     * beta version, just add that to the 100. "2.1.105.3" will render as "2.2.5b3".
                     * If you do not want the beta update to be pushed to the user, set the revision above 100.
                    **/

                    Boolean doUpdate = true;

                    int betaMinor = info.AvailableVersion.Minor + 1; // The minor needs to increment by 1
                    int betaBuild = info.AvailableVersion.Build - 100; // Subtract 100 to get our build

                    string betaVersion = betaBuild < 1
                                         ? // Build 0 in x.xbx format, i.e. 2.3b7
                                         info.AvailableVersion.Major + "." + betaMinor + "b" +
                                         info.AvailableVersion.Revision
                                         : // With build number in x.x.xbx format, i.e. 4.2.1b2
                                         info.AvailableVersion.Major + "." + betaMinor + "." +
                                         betaBuild + "b" + info.AvailableVersion.Revision;


                    if (!info.IsUpdateRequired)
                    {
                        DialogResult dr = MessageBox.Show("A beta update is available. " +
                                                          "Would you like to update this application to beta version " +
                                                          betaVersion + " now? The release includes " +
                                                          "new features that are still being perfected. If you do not " +
                                                          "want to test possibly unstable features, do not upgrade " +
                                                          "until the next stable release.",
                                                          "Beta Update Available - " + betaVersion,
                                                          MessageBoxButtons.OKCancel);
                        if (DialogResult.OK != dr) doUpdate = false;
                    }
                    else // Display a message that the app MUST reboot. Display the minimum required version.
                        MessageBox.Show("This application has detected a mandatory update from your current " +
                                        "version to version " + info.MinimumRequiredVersion +
                                        ". The application will now install the update and restart.",
                                        "Mandatory Update - " + info.MinimumRequiredVersion,
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (doUpdate)
                    {
                        try
                        {
                            ad.Update();
                            MessageBox.Show("The beta has been installed and the application will now restart.",
                                            "Beta " + betaVersion + " Successfully Installed");
                            Application.Restart();
                        }
                        catch (DeploymentDownloadException dde)
                        {
                            MessageBox.Show("Cannot install this beta." +
                                            "\n\nPlease check your network connection, or try again later. Error: " +
                                            dde, "Installation Failed");
                            return;
                        }
                    }
                }
                else if (info.UpdateAvailable) // For stable release
                {
                    Boolean doUpdate = true;

                    // Gives us a cleaner version number, i.e. 3.4 instead of 3.4.0.0. Will still give 2.0 or 3.2.0.1
                    string stableVersion = info.AvailableVersion.Major + "." + info.AvailableVersion.Minor;
                    if (info.AvailableVersion.Build != 0)
                    {
                        stableVersion += "." + info.AvailableVersion.Build;
                        if (info.AvailableVersion.Revision != 0) stableVersion += "." + info.AvailableVersion.Revision;
                    }
                    else if (info.AvailableVersion.Revision != 0) stableVersion += ".0." + info.AvailableVersion.Revision;

                    if (!info.IsUpdateRequired)
                    {
                        DialogResult dr = MessageBox.Show("An update is available. " +
                                                          "Would you like to update the application to version " +
                                                          stableVersion + " now?",
                                                          "Update Available - " + stableVersion,
                                                          MessageBoxButtons.OKCancel);
                        if (DialogResult.OK != dr) doUpdate = false;
                    }
                    else // Display a message that the app MUST reboot. Display the minimum required version.
                        MessageBox.Show("This application has detected a mandatory update from your current " +
                                        "version to version " + stableVersion +
                                        ". The application will now install the update and restart.",
                                        "Mandatory Update - " + stableVersion,
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (doUpdate)
                    {
                        try
                        {
                            ad.Update();
                            MessageBox.Show("The application has been upgraded, and will now restart.",
                                            "Update " + stableVersion + " Successfully Installed");
                            Application.Restart();
                        }
                        catch (DeploymentDownloadException dde)
                        {
                            MessageBox.Show("Cannot install the latest version of the application." +
                                            "\n\nPlease check your network connection, or try again later. Error: " +
                                            dde, "Installation Failed");
                            return;
                        }
                    }
                }
                else if (x == 1) MessageBox.Show("There are currently no updates available for this application.",
                                                 "No Updates Available");
                else if (x == 2)
                {
                    DialogResult dr = MessageBox.Show("There are currently no stable updates available for this " +
                                                      "application.\n\nWould you like to check for a beta release?",
                                                      "No Stable Updates Available", MessageBoxButtons.YesNo);
                    if (DialogResult.Yes == dr) this.InstallUpdateSyncWithInfo(1);
                }
            }
            else if (x == 1 || x == 2) // If they're booting an exe that isn't installed from the deployment...
            {
                DialogResult dr = MessageBox.Show("This application has not been installed from its deployment location." +
                                                  "\n\nWould you like to go to the official website and install this " +
                                                  "application with update checking enabled?",
                                                  "Not Installed From Network", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == dr) openURL("http://www.chaosutilities.tk/ndscodingtools/activatorcalc/");
            }
        }
    }
}
