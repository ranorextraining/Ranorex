/*
 * Created by Ranorex
 * User: training
 * Date: 12/21/2021
 * Time: 8:12 PM
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
    /// Creates a Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class UserCodeCollection1
    {
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        
        
         [UserCodeMethod]
        public void showMessageBox(String Message)
        {
        	WinForms.MessageBox.Show("Message = " + Message);
        	//https://jsonplaceholder.typicode.com/todos/1
        }
    }
}
