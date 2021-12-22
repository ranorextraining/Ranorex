/*
 * Created by Ranorex
 * User: training
 * Date: 12/21/2021
 * Time: 8:15 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace WebTest
{
    /// <summary>
    /// Description of UserCodeModule1.
    /// </summary>
    [TestModule("F132A8D9-44A1-47AC-8D23-EA8C5D62DCCA", ModuleType.UserCode, 1)]
    public class UserCodeModule1 : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UserCodeModule1()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            String apiUrl = "https://jsonplaceholder.typicode.com/todos/1";
            
            RestSharp.RestClient api = new RestSharp.RestClient(apiUrl);
            RestSharp.RestRequest request = new RestSharp.RestRequest(RestSharp.Method.GET);
            
            RestSharp.IRestResponse response = api.Execute(request);
            
            WinForms.MessageBox.Show(response.ResponseStatus.ToString());
            
            Report.Log(ReportLevel.Info, response.ResponseStatus.ToString());
            Report.Log(ReportLevel.Info,response.Content);
            
            WinForms.MessageBox.Show(response.Content);
        }
    }
}
