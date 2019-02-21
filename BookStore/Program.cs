/*
 * Author: Giorgi Aptsiauri 
 * Date: 2/10/2019
 * For class: COMPE 561
 * 
 * Description: The purpose of this application is to create an order windows where 
 * users can choose to add products. The app intelligently manages to only respond to
 * correct inputs. Order details are visually shown for the user's convenience. 
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BookStoreForm());
        }
    }
}
