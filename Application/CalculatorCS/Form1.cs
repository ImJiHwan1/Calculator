using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Runtime.InteropServices;

namespace CalculatorCS
{
    public partial class Form1 : Form
    {
        int m_hDLL;
        int a, b;
        IntPtr intPtr;



        [DllImport("kernel32.dll", EntryPoint = "LoadLibrary")]
    private extern static int LoadLibrary(string libraryname);

    [DllImport("kernel32.dll", EntryPoint = "GetProcAddress")]
    private extern static IntPtr GetProcAddress(int hwnd, string proname);

    [DllImport("kernel32.dll", EntryPoint = "FreeLibrary")]
    private extern static bool FreeLibrary(int hModule);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        delegate int EngineInitCS();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        delegate int EngineReleaseCS();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        delegate int EngineCalCS(int a, int b);

        public Form1()
        {
            unsafe
            {
                m_hDLL = LoadLibrary("CalDll.dll");
                if (m_hDLL == 0) MessageBox.Show("Error dll load!");
            }
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void Calculator ( int op)
        {
            // 공통 코드(TextBox 입력값 읽기)
            if (int.TryParse(TextBox1.Text, out a) == false) return;
            if (int.TryParse(TextBox2.Text, out b) == false) return;
            // Dll 호출 파라미터 설정(+,-,x,/)
            switch ( op )
            {
                case 1:
                    intPtr = GetProcAddress(m_hDLL, "EngineAdd");
                    labelOperation.Text = "+";
                    break;
                case 2:
                    intPtr = GetProcAddress(m_hDLL, "EngineSub");
                    labelOperation.Text = "-";
                    break;
                case 3:
                    intPtr = GetProcAddress(m_hDLL, "EngineMul");
                    labelOperation.Text = "X";
                    break;
                case 4:
                    intPtr = GetProcAddress(m_hDLL, "EngineDiv");
                    labelOperation.Text = "/";
                    break;
            }
            // 공통코드(Dll 호출 및 결과 출력)
            EngineCalCS Add =
               (EngineCalCS)Marshal.GetDelegateForFunctionPointer(intPtr,
               typeof(EngineCalCS));
            int c = Add(a, b);
            TextBox3.Text = c.ToString();
            Refresh();

            EngineCalCS Sub =
               (EngineCalCS)Marshal.GetDelegateForFunctionPointer(intPtr,
               typeof(EngineCalCS));
            int d = Sub(a, b);
            TextBox3.Text = d.ToString();
            Refresh();

            EngineCalCS Mul =
               (EngineCalCS)Marshal.GetDelegateForFunctionPointer(intPtr,
               typeof(EngineCalCS));
            int e = Mul(a, b);
            TextBox3.Text = e.ToString();
            Refresh();

            EngineCalCS Div =
                (EngineCalCS)Marshal.GetDelegateForFunctionPointer(intPtr,
                typeof(EngineCalCS));
            int f = Div(a, b);
            TextBox3.Text = f.ToString();
            Refresh();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Calculator(1);
        }

        private void ButtonSub_Click(object sender, EventArgs e)
        {
            Calculator(2);
        }

        private void ButtonMul_Click(object sender, EventArgs e)
        {
            Calculator(3);
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonDiv_Click(object sender, EventArgs e)
        {
            Calculator(4);
        }
    }
}
