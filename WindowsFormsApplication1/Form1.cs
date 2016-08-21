using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public string[] arrItemMenu_AB = new string[3] { "KAHAЛ   3AHЯT", "C/Ш ", "KAЧECTBO MEPИTЬ?"};
        public string[] arrItemMenu_ABC = new string[2] { "xxx", "vvvvvvv" };

        public Boo b1 ;

        static string Union(string[] array)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < array.Length; i++)
            {
                {
                    sb.Append(array[i] + ",");
                }
            }
            sb.Append(array[array.Length - 1]);

            return sb.ToString();
        }

        static string Union_old(string[] array)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < array.Length; i++)
            {
                if (i + 1 == array.Length)
                {
                    sb.Append(array[i]);
                }
                else
                {
                    sb.Append(array[i] + ",");
                }
            }
            return sb.ToString();
        }
        
        public Form1()
        {
            InitializeComponent();
            // Union = Union(arrItemMenu_ABC);

            Console.WriteLine(Union(arrItemMenu_AB));

            b1 = new Boo();
        }
    }
}
