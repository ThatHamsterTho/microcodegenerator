using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace microcode
{
    public partial class Form1 : Form
    {
        public static void PrintValues(IEnumerable myList, int myWidth)
        {
            int i = myWidth;
            foreach (Object obj in myList)
            {
                if (i <= 0)
                {
                    i = myWidth;
                    Console.WriteLine();
                }
                i--;
                Console.Write("{0,8}", obj);
            }
            Console.WriteLine();
        }

        public List<int[]> FLAGS = new List<int[]>{
            new int [] { 0, 0 },
            new int [] { 0, 1 },
            new int [] { 1, 0 },
            new int [] { 1, 1 },
        };
        public List<int[]> ALUINSTR = new List<int[]>
        {
            new int [] { 0, 0, 0 },
            new int [] { 0, 0, 1 },
            new int [] { 0, 1, 0 },
            new int [] { 0, 1, 1 },
            new int [] { 1, 0, 0 },
            new int [] { 1, 0, 1 },
            new int [] { 1, 1, 0 },
            new int [] { 1, 1, 1 }
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private int[] convert2bits(int num, int length)
        {
            int[] bits = new int[length];
            BitArray b = new BitArray(new int[] { num });
            for (int c = 0; c < length; c++)
            {
                bits[c] = b[c] ? 1 : 0;
            }
            Array.Reverse(bits);
            return bits;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] flagbit = new int[2] { 0, 0 };
            int[] ALUbit = new int[3] { 0, 0, 0 };
            try
            {
                flagbit = FLAGS[FLAG.SelectedIndex];
            }
            catch (System.ArgumentOutOfRangeException exc)
            {
                Console.WriteLine(exc.Message);
            }
            try
            {
                ALUbit = ALUINSTR[ALU.SelectedIndex];
            }
            catch (System.ArgumentOutOfRangeException exc)
            {
                Console.WriteLine(exc.Message);
            }
            

            int[] mc510bits = new int[6];
            for (int c = 0; c < mc510.Items.Count; c++)
            {
                mc510bits[c] = mc510.CheckedItems.Contains(mc510.Items[c]) ? 1 : 0;
            }

            int[] regA = convert2bits(decimal.ToInt32(REGA.Value), 3);
            int[] regB = convert2bits(decimal.ToInt32(REGB.Value), 3);
            int[] regOut = convert2bits(decimal.ToInt32(REGOUT.Value), 3);
            int[] mcpcaddr = convert2bits(decimal.ToInt32(MCPC.Value), 7);

            List<int[]> machinecodebits = new List<int[]>{ flagbit, ALUbit, mc510bits, regA, regB, regOut, mcpcaddr };

            string machinecode = "";
            foreach (var item in machinecodebits)
            {
                foreach (var item2 in item)
                {
                    machinecode += item2.ToString();
                }
            }

            output.Text = machinecode;
        }
    }
}
