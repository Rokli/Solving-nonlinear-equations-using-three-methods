using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Iterations
{
    //public partial class Nuton
    //{
    //    public float eps { get; set; } = 0.000001f;
    //    public Nuton()
    //    {
    //    }

    //    private void button1_Click(object sender, EventArgs e)
    //    {
    //        List<float> y = new List<float>();
    //        List<float> x = new List<float>();
    //        x.Add(5f);
    //        x.Add(1f);
    //        x.Add(-1f);
    //        x.Add(-5f);

    //        richTextBox1.Text += "Корень 1";
    //        Calculate(x[0]);

    //        richTextBox1.Text += "\nКорень 2";
    //        Calculate(x[1]);

    //        richTextBox1.Text += "\nКорень 3";
    //        Calculate(x[2]);

    //        richTextBox1.Text += "\nКорень 4";
    //        Calculate(x[3]);
    //    }
    //    private float Calculate(float x_0)
    //    {
    //        float x_1 = x_0 - NoDir(x_0) / Dir(x_0);
    //        while (Math.Abs(x_1 - x_0) > eps)
    //        {
    //            x_0 = x_1;
    //            x_1 = x_0 - NoDir(x_0) / Dir(x_0);
    //            richTextBox1.Text += $"\n{x_0}";
    //        }
    //        return x_1;
    //    }
    //    private float NoDir(float x)
    //    {
    //        return 2 * (float)Math.Pow(x, 4) - 24 * (float)Math.Pow(x, 2) - x + 8;
    //    }
    //    private float Dir(float x)
    //    {
    //        return 8 * (float)Math.Pow(x, 3) - 48 * x - 1;
    //    }
    //}
}
