using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace АйпиКалькулятор
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Insert(0, "	0.0.0.0");
            comboBox1.Items.Insert(1, "128.0.0.0");
            comboBox1.Items.Insert(2, "192.0.0.0");
            comboBox1.Items.Insert(3, "224.0.0.0");
            comboBox1.Items.Insert(4, "240.0.0.0");
            comboBox1.Items.Insert(5, "248.0.0.0");
            comboBox1.Items.Insert(6, "252.0.0.0");
            comboBox1.Items.Insert(7, "254.0.0.0");
            comboBox1.Items.Insert(8, "255.0.0.0");
            comboBox1.Items.Insert(9, "255.128.0.0");
            comboBox1.Items.Insert(10, "255.192.0.0");
            comboBox1.Items.Insert(11, "255.224.0.0");
            comboBox1.Items.Insert(12, "255.240.0.0");
            comboBox1.Items.Insert(13, "255.248.0.0");
            comboBox1.Items.Insert(14, "255.252.0.0");
            comboBox1.Items.Insert(15, "255.254.0.0");
            comboBox1.Items.Insert(16, "255.255.0.0");
            comboBox1.Items.Insert(17, "255.255.128.0");
            comboBox1.Items.Insert(18, "255.255.192.0");
            comboBox1.Items.Insert(19, "255.255.224.0");
            comboBox1.Items.Insert(20, "255.255.240.0");
            comboBox1.Items.Insert(21, "255.255.248.0");
            comboBox1.Items.Insert(22, "255.255.252.0");
            comboBox1.Items.Insert(23, "255.255.254.0");
            comboBox1.Items.Insert(24, "255.255.255.0");
            comboBox1.Items.Insert(25, "255.255.255.128");
            comboBox1.Items.Insert(26, "255.255.255.192");
            comboBox1.Items.Insert(27, "255.255.255.224");
            comboBox1.Items.Insert(28, "255.255.255.240");
            comboBox1.Items.Insert(29, "255.255.255.248");
            comboBox1.Items.Insert(30, "255.255.255.252");
            comboBox1.Items.Insert(31, "255.255.255.254");
            comboBox1.Items.Insert(32, "255.255.255.255");
            textBox1.Text = "Выберите маску";
            textBox2.Text = "Запишите Ip Adress";
            textBox6.Text = "Широковещательный";
            textBox7.Text = "Подсеть";
            textBox8.Text = "Кол-во адресов";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {    

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)

        {
            double host=0;
            switch (comboBox1.SelectedIndex) {
                case 0:  host = 0;                
                    break;
                case 1: host = 1;
                    break;
                case 2: host = 2;
                    break;
                case 3: host = 3;
                    break;
                case 4: host = 4;
                    break;
                case 5: host = 5;
                    break;
                case 6: host = 6;
                    break;
                case 7: host = 7;
                    break;
                case 8: host = 8;
                    break;
                case 9: host = 9;
                    break;
                case 10: host = 10;
                    break;
                case 11: host = 11;
                    break;
                case 12: host = 12;
                    break;
                case 13: host = 13;
                    break;
                case 14: host = 14;
                    break;
                case 15: host = 15;
                    break;
                case 16: host = 16;
                    break;
                case 17: host= 17;
                    break;
                case 18: host = 18;
                    break;
                case 19: host = 19;
                    break;
                case 20: host = 20;
                    break;
                case 21: host = 21;
                    break;
                case 22: host = 22;
                    break;
                case 23: host = 23;
                    break;
                case 24: host = 24;
                    break;
                case 25: host = 25;
                    break;
                case 26: host = 26;
                    break;
                case 27: host = 27;
                    break;
                case 28: host = 28;
                    break;
                case 29: host = 29;
                    break;
                case 30: host = 30;
                    break;
                case 31: host = 31;
                    break;
                case 32: host = 32;
                    break;
                default: break;
        }
            double reshost = Math.Pow(2,32-host);
            reshost=Convert.ToInt32(reshost);
            if (host < 31)
            {
                textBox9.Text = reshost.ToString();
            }
            
            string sMask;
            sMask = textBox3.Text;
            string sMaskCh="";
            int k=0;
            for (int i = sMask.Length-1; i>0; i--)
            {
               if(sMask[i] == '.')
                {
                    k = i;
                    break;
                }

            }
            for(int i=k+1; i<sMask.Length; i++)
            {
                sMaskCh = sMaskCh + sMask[i];
            }
            int diapozon=Convert.ToInt32(sMaskCh);
            switch (host)
            {
                case 24: diapozon = 0;
                    break;
                case 25: if (diapozon > 0 && diapozon < 128)
                    {
                        diapozon = 0;
                    }
                    else diapozon = 128;
                    break;
                case 26: if (diapozon > 0 && diapozon < 64)                   
                        diapozon = 0;
                    if (diapozon > 64 && diapozon < 128)
                        diapozon = 64;
                    if (diapozon > 128 && diapozon < 192)
                        diapozon = 128;
                    if (diapozon > 192 && diapozon < 256)
                        diapozon = 192;
                    break;
                case 27:if (diapozon > 0 && diapozon < 32)
                        diapozon = 0;
                    if (diapozon > 32 && diapozon < 64)
                        diapozon = 32;
                    if (diapozon > 64 && diapozon < 128)
                        diapozon = 64;
                    if (diapozon > 128 && diapozon < 160)
                        diapozon = 128;
                    if (diapozon > 160 && diapozon < 192)
                        diapozon = 160;
                    if (diapozon > 192 && diapozon < 224)
                        diapozon = 192;
                    if (diapozon > 224 && diapozon < 256)
                        diapozon = 224;
                    break;
                case 28:
                    if (diapozon > 0 && diapozon < 16)
                        diapozon = 0;
                    if (diapozon > 16 && diapozon < 32)
                        diapozon = 16;
                    if (diapozon > 32 && diapozon < 48)
                        diapozon = 32;
                    if (diapozon > 48 && diapozon < 64)
                        diapozon = 48;
                    if (diapozon > 64 && diapozon < 80)
                        diapozon =64;
                    if (diapozon > 80 && diapozon < 96)
                        diapozon = 64;
                    if (diapozon > 96 && diapozon < 112)
                        diapozon = 96;
                    if (diapozon > 112 && diapozon < 128)
                        diapozon = 112;
                    if (diapozon > 128 && diapozon < 144)
                        diapozon = 128;
                    if (diapozon > 144 && diapozon < 160)
                        diapozon = 144;
                    if (diapozon > 160 && diapozon < 176)
                        diapozon = 160;
                    if (diapozon > 176 && diapozon < 192)
                        diapozon = 176;
                    if (diapozon > 192 && diapozon < 208)
                        diapozon = 192;
                    if (diapozon > 208 && diapozon < 224)
                        diapozon = 208;
                    if (diapozon > 224 && diapozon < 240)
                        diapozon = 224;
                    if (diapozon > 240 && diapozon < 256)
                        diapozon = 240;
                    break;
                case 29:
                    if (diapozon > 0 && diapozon < 8)
                        diapozon = 0;
                    if (diapozon > 8 && diapozon < 16)
                        diapozon = 8;
                    if (diapozon > 16 && diapozon < 24)
                        diapozon = 16;
                    if (diapozon > 24 && diapozon < 32)
                        diapozon = 24;
                    if (diapozon > 32 && diapozon < 40)
                        diapozon = 32;
                    if (diapozon > 40 && diapozon < 48)
                        diapozon = 40;
                    if (diapozon > 48 && diapozon < 56)
                        diapozon = 48;
                    if (diapozon > 56 && diapozon < 64)
                        diapozon = 56;
                    if (diapozon > 64 && diapozon < 72)
                        diapozon = 64;
                    if (diapozon > 72 && diapozon < 80)
                        diapozon = 72;
                    if (diapozon > 80 && diapozon < 88)
                        diapozon = 80;
                    if (diapozon > 88 && diapozon < 96)
                        diapozon = 88;
                    if (diapozon > 96 && diapozon < 104)
                        diapozon = 96;
                    if (diapozon > 104 && diapozon < 112)
                        diapozon = 104;
                    if (diapozon > 112 && diapozon < 120)
                        diapozon = 112;
                    if (diapozon > 120 && diapozon < 128)
                        diapozon = 120;
                    if (diapozon > 128 && diapozon < 136)
                        diapozon = 128;
                    if (diapozon > 136 && diapozon < 144)
                        diapozon = 136;
                    if (diapozon > 144 && diapozon <152)
                        diapozon = 144;
                    if (diapozon > 152 && diapozon < 160)
                        diapozon = 152;
                    if (diapozon > 160 && diapozon < 168)
                        diapozon = 160;
                    if (diapozon > 168 && diapozon < 176)
                        diapozon = 168;
                    if (diapozon > 176 && diapozon < 184)
                        diapozon = 176;
                    if (diapozon > 184 && diapozon < 192)
                        diapozon = 184;
                    if (diapozon > 192 && diapozon < 200)
                        diapozon = 192;
                    if (diapozon > 200 && diapozon < 208)
                        diapozon = 200;
                    if (diapozon > 208 && diapozon < 216)
                        diapozon = 208;
                    if (diapozon > 216 && diapozon < 224)
                        diapozon = 216;
                    if (diapozon > 224 && diapozon < 232)
                        diapozon = 224;
                    if (diapozon > 232 && diapozon < 248)
                        diapozon = 232;
                    if (diapozon > 248 && diapozon < 256)
                        diapozon = 248;

                    break;
                case 30:
                    if (diapozon > 0 && diapozon < 4)
                        diapozon = 0;
                    if (diapozon > 4 && diapozon < 8)
                        diapozon = 4;
                    if (diapozon > 8 && diapozon < 12)
                        diapozon = 8;
                    if (diapozon > 12 && diapozon < 16)
                        diapozon = 12;
                    if (diapozon > 16 && diapozon < 20)
                        diapozon = 16;
                    if (diapozon > 20 && diapozon < 24)
                        diapozon = 20;
                    if (diapozon > 24 && diapozon < 28)
                        diapozon = 24;
                    if (diapozon > 28 && diapozon < 32)
                        diapozon = 28;
                    if (diapozon > 32 && diapozon < 36)
                        diapozon = 32;
                    if (diapozon > 36 && diapozon < 40)
                        diapozon = 36;
                    if (diapozon > 40 && diapozon < 44)
                        diapozon = 40;
                    if (diapozon > 44 && diapozon < 48)
                        diapozon = 44;
                    if (diapozon > 48 && diapozon < 52)
                        diapozon = 48;
                    if (diapozon > 52 && diapozon < 56)
                        diapozon = 52;
                    if (diapozon > 56 && diapozon < 60)
                        diapozon = 56;
                    if (diapozon > 60 && diapozon < 64)
                        diapozon = 60;
                    if (diapozon > 64 && diapozon < 68)
                        diapozon = 64;
                    if (diapozon > 68 && diapozon < 72)
                        diapozon = 68;
                    if (diapozon > 72 && diapozon < 76)
                        diapozon = 72;
                    if (diapozon > 76 && diapozon < 80)
                        diapozon = 76;
                    if (diapozon > 80 && diapozon < 84)
                        diapozon = 80;
                    if (diapozon > 84 && diapozon < 88)
                        diapozon = 84;
                    if (diapozon > 88 && diapozon < 92)
                        diapozon = 88;
                    if (diapozon > 92 && diapozon < 96)
                        diapozon = 92;
                    if (diapozon > 96 && diapozon < 100)
                        diapozon = 96;
                    if (diapozon > 100 && diapozon < 104)
                        diapozon = 100;
                    if (diapozon > 104 && diapozon < 108)
                        diapozon = 104;
                    if (diapozon > 108 && diapozon < 112)
                        diapozon = 108;
                    if (diapozon > 112 && diapozon < 116)
                        diapozon = 112;
                    if (diapozon > 116 && diapozon < 120)
                        diapozon = 116;
                    if (diapozon > 120 && diapozon < 124)
                        diapozon = 120;
                    if (diapozon > 124 && diapozon < 128)
                        diapozon = 124;
                    if (diapozon > 128 && diapozon < 132)
                        diapozon = 128;
                    if (diapozon > 132 && diapozon < 136)
                        diapozon = 132;
                    if (diapozon > 136 && diapozon < 140)
                        diapozon = 136;
                    if (diapozon > 140 && diapozon < 144)
                        diapozon = 140;
                    if (diapozon > 144 && diapozon < 148)
                        diapozon = 144;
                    if (diapozon > 148 && diapozon < 152)
                        diapozon = 148;
                    if (diapozon > 152 && diapozon < 156)
                        diapozon = 152;
                    if (diapozon > 156 && diapozon < 160)
                        diapozon = 156;
                    if (diapozon > 160 && diapozon < 164)
                        diapozon = 160;
                    if (diapozon > 164 && diapozon < 168)
                        diapozon = 164;
                    if (diapozon > 168 && diapozon < 172)
                        diapozon = 168;
                    if (diapozon > 172 && diapozon < 174)
                        diapozon = 172;
                    if (diapozon > 176 && diapozon < 180)
                        diapozon = 176;
                    if (diapozon > 180 && diapozon < 184)
                        diapozon = 180;
                    if (diapozon > 184 && diapozon < 188)
                        diapozon = 184;
                    if (diapozon > 188 && diapozon < 192)
                        diapozon = 188;
                    if (diapozon > 192 && diapozon < 196)
                        diapozon = 192;
                    if (diapozon > 196 && diapozon < 200)
                        diapozon = 196;
                    if (diapozon > 200 && diapozon < 204)
                        diapozon = 200;
                    if (diapozon > 204 && diapozon < 208)
                        diapozon = 204;
                    if (diapozon > 208 && diapozon < 212)
                        diapozon = 208;
                    if (diapozon > 212 && diapozon < 216)
                        diapozon = 212;
                    if (diapozon > 216 && diapozon < 220)
                        diapozon = 216;
                    if (diapozon > 220 && diapozon < 224)
                        diapozon = 220;
                    if (diapozon > 224 && diapozon < 228)
                        diapozon = 224;
                    if (diapozon > 224 && diapozon < 232)
                        diapozon = 224;
                    if (diapozon > 232 && diapozon < 236)
                        diapozon = 232;
                    if (diapozon > 236 && diapozon < 240)
                        diapozon = 236;
                    if (diapozon > 240 && diapozon < 244)
                        diapozon = 240;
                    if (diapozon > 244 && diapozon < 248)
                        diapozon = 244;
                    if (diapozon > 248 && diapozon < 252)
                        diapozon = 248;
                    if (diapozon > 252 && diapozon < 256)
                        diapozon = 252;
                    break;
                case 31:
                    if (diapozon > 0 && diapozon < 2)
                        diapozon = 0;
                    if (diapozon > 2 && diapozon < 4)
                        diapozon = 2;
                    if (diapozon > 4 && diapozon < 6)
                        diapozon = 4;
                    if (diapozon > 6 && diapozon < 8)
                        diapozon = 6;
                    if (diapozon > 8 && diapozon < 10)
                        diapozon = 8;
                    if (diapozon > 10 && diapozon < 12)
                        diapozon = 10;
                    if (diapozon > 12 && diapozon < 14)
                        diapozon = 12;
                    if (diapozon > 14 && diapozon < 16)
                        diapozon = 14;
                    if (diapozon > 16 && diapozon < 18)
                        diapozon = 16;
                    if (diapozon > 18 && diapozon < 20)
                        diapozon = 18;
                    if (diapozon > 20 && diapozon < 22)
                        diapozon = 20;
                    if (diapozon > 22 && diapozon < 24)
                        diapozon = 22;
                    if (diapozon > 24 && diapozon < 26)
                        diapozon = 24;
                    if (diapozon > 26 && diapozon < 28)
                        diapozon = 26;
                    if (diapozon > 28 && diapozon < 30)
                        diapozon = 28;
                    if (diapozon > 30 && diapozon < 32)
                        diapozon = 30;
                    if (diapozon > 32 && diapozon < 34)
                        diapozon = 32;
                    if (diapozon > 34 && diapozon < 36)
                        diapozon = 34;
                    if (diapozon > 36 && diapozon < 38)
                        diapozon = 36;
                    if (diapozon > 38 && diapozon < 40)
                        diapozon = 38;
                    if (diapozon > 40 && diapozon < 42)
                        diapozon = 40;
                    if (diapozon > 42 && diapozon < 44)
                        diapozon = 42;
                    if (diapozon > 44 && diapozon < 46)
                        diapozon = 44;
                    if (diapozon > 46 && diapozon < 48)
                        diapozon = 46;
                    if (diapozon > 48 && diapozon < 50)
                        diapozon = 48;
                    if (diapozon > 50 && diapozon < 52)
                        diapozon = 50;
                    if (diapozon > 52 && diapozon < 54)
                        diapozon = 52;
                    if (diapozon > 54 && diapozon < 56)
                        diapozon = 54;
                    if (diapozon > 56 && diapozon < 58)
                        diapozon = 56;
                    if (diapozon > 58 && diapozon <60)
                        diapozon = 58;
                    if (diapozon > 60 && diapozon < 62)
                        diapozon = 60;
                    if (diapozon > 62 && diapozon < 64)
                        diapozon = 62;
                    if (diapozon > 64 && diapozon < 66)
                        diapozon = 64;
                    if (diapozon > 66 && diapozon < 68)
                        diapozon = 66;
                    if (diapozon > 68 && diapozon < 70)
                        diapozon = 68;
                    if (diapozon > 70 && diapozon < 72)
                        diapozon = 70;
                    if (diapozon > 72 && diapozon < 74)
                        diapozon = 72;
                    if (diapozon > 74 && diapozon < 76)
                        diapozon = 74;
                    if (diapozon > 76 && diapozon < 78)
                        diapozon = 76;
                    if (diapozon > 78 && diapozon < 80)
                        diapozon = 78;
                    if (diapozon > 80 && diapozon < 82)
                        diapozon = 80;
                    if (diapozon > 82 && diapozon < 84)
                        diapozon = 82;
                    if (diapozon > 84 && diapozon < 86)
                        diapozon = 84;
                    if (diapozon > 86 && diapozon < 88)
                        diapozon = 86;
                    if (diapozon > 88 && diapozon < 90)
                        diapozon = 88;
                    if (diapozon > 90 && diapozon < 92)
                        diapozon = 90;
                    if (diapozon > 92 && diapozon < 94)
                        diapozon = 92;
                    if (diapozon > 94 && diapozon < 96)
                        diapozon = 94;
                    if (diapozon > 96 && diapozon < 98)
                        diapozon = 96;
                    if (diapozon > 98 && diapozon < 100)
                        diapozon = 98;
                    if (diapozon > 100 && diapozon < 102)
                        diapozon = 100;
                    if (diapozon > 102 && diapozon < 104)
                        diapozon = 102;
                    if (diapozon > 104 && diapozon < 106)
                        diapozon = 104;
                    if (diapozon > 106 && diapozon < 108)
                        diapozon = 106;
                    if (diapozon > 108 && diapozon < 110)
                        diapozon = 108;
                    if (diapozon > 110 && diapozon < 112)
                        diapozon = 110;
                    if (diapozon > 112 && diapozon < 114)
                        diapozon = 112;
                    if (diapozon > 114 && diapozon < 116)
                        diapozon = 114;
                    if (diapozon > 116 && diapozon < 118)
                        diapozon = 116;
                    if (diapozon > 118 && diapozon < 120)
                        diapozon = 118;
                    if (diapozon > 120 && diapozon < 122)
                        diapozon = 120;
                    if (diapozon > 122 && diapozon < 124)
                        diapozon = 122;
                    if (diapozon > 124 && diapozon < 126)
                        diapozon = 124;
                    if (diapozon > 126 && diapozon < 128)
                        diapozon = 126;
                    if (diapozon > 128 && diapozon < 130)
                        diapozon = 128;
                    if (diapozon > 130 && diapozon < 132)
                        diapozon = 130;
                    if (diapozon > 132 && diapozon < 134)
                        diapozon = 132;
                    if (diapozon > 134 && diapozon < 136)
                        diapozon = 134;
                    if (diapozon > 136 && diapozon < 138)
                        diapozon = 136;
                    if (diapozon > 138 && diapozon < 140)
                        diapozon = 138;
                    if (diapozon > 140 && diapozon < 142)
                        diapozon = 140;
                    if (diapozon > 142 && diapozon < 144)
                        diapozon = 142;
                    if (diapozon > 144 && diapozon < 146)
                        diapozon = 144;
                    if (diapozon > 146 && diapozon < 148)
                        diapozon = 146;
                    if (diapozon > 148 && diapozon < 150)
                        diapozon = 148;
                    if (diapozon > 150 && diapozon < 152)
                        diapozon = 150;
                    if (diapozon > 152 && diapozon < 154)
                        diapozon = 152;
                    if (diapozon > 154 && diapozon < 156)
                        diapozon = 154;
                    if (diapozon > 156 && diapozon < 158)
                        diapozon = 156;
                    if (diapozon > 158 && diapozon < 160)
                        diapozon = 158;
                    if (diapozon > 160 && diapozon < 162)
                        diapozon = 160;
                    if (diapozon > 162 && diapozon < 164)
                        diapozon = 162;
                    if (diapozon > 164 && diapozon < 166)
                        diapozon = 164;
                    if (diapozon > 166 && diapozon < 168)
                        diapozon = 166;
                    if (diapozon > 168 && diapozon < 170)
                        diapozon = 168;
                    if (diapozon > 170 && diapozon < 172)
                        diapozon = 170;
                    if (diapozon > 172 && diapozon < 174)
                        diapozon = 172;
                    if (diapozon > 174 && diapozon < 176)
                        diapozon = 174;
                    if (diapozon > 176 && diapozon < 178)
                        diapozon = 176;
                    if (diapozon > 178 && diapozon < 180)
                        diapozon = 178;
                    if (diapozon > 182 && diapozon < 184)
                        diapozon = 182;
                    if (diapozon > 184 && diapozon < 186)
                        diapozon = 184;
                    if (diapozon > 186 && diapozon < 188)
                        diapozon = 186;
                    if (diapozon > 188 && diapozon < 190)
                        diapozon = 188;
                    if (diapozon > 190 && diapozon < 192)
                        diapozon = 190;
                    if (diapozon > 192 && diapozon < 194)
                        diapozon = 192;
                    if (diapozon > 194 && diapozon < 196)
                        diapozon = 194;
                    if (diapozon > 196 && diapozon < 198)
                        diapozon = 196;
                    if (diapozon > 198 && diapozon < 200)
                        diapozon = 198;
                    if (diapozon > 200 && diapozon < 202)
                        diapozon = 200;
                    if (diapozon > 202 && diapozon < 204)
                        diapozon = 202;
                    if (diapozon > 204 && diapozon < 206)
                        diapozon = 204;
                    if (diapozon > 206 && diapozon < 208)
                        diapozon = 206;
                    if (diapozon > 208 && diapozon < 210)
                        diapozon = 208;
                    if (diapozon > 210 && diapozon < 212)
                        diapozon = 210;
                    if (diapozon > 212 && diapozon < 214)
                        diapozon = 212;
                    if (diapozon > 214 && diapozon < 216)
                        diapozon = 214;
                    if (diapozon > 216 && diapozon < 218)
                        diapozon = 216;
                    if (diapozon > 218 && diapozon < 220)
                        diapozon = 218;
                    if (diapozon > 220 && diapozon < 222)
                        diapozon = 220;
                    if (diapozon > 222 && diapozon < 224)
                        diapozon = 222;
                    if (diapozon > 224 && diapozon < 226)
                        diapozon = 224;
                    if (diapozon > 226 && diapozon < 228)
                        diapozon = 226;
                    if (diapozon > 228 && diapozon < 230)
                        diapozon = 228;
                    if (diapozon > 230 && diapozon < 232)
                        diapozon = 230;
                    if (diapozon > 232 && diapozon < 234)
                        diapozon = 232;
                    if (diapozon > 234 && diapozon < 236)
                        diapozon = 234;
                    if (diapozon > 236 && diapozon < 238)
                        diapozon = 236;
                    if (diapozon > 238 && diapozon < 240)
                        diapozon = 238;
                    if (diapozon > 240 && diapozon < 242)
                        diapozon = 240;
                    if (diapozon > 242 && diapozon < 244)
                        diapozon = 242;
                    if (diapozon > 244 && diapozon < 246)
                        diapozon = 244;
                    if (diapozon > 246 && diapozon < 248)
                        diapozon = 246;
                    if (diapozon > 248 && diapozon < 250)
                        diapozon = 248;
                    if (diapozon > 250 && diapozon < 252)
                        diapozon = 250;
                    if (diapozon > 252 && diapozon < 254)
                        diapozon = 252;
                    if (diapozon > 254 && diapozon < 256)
                        diapozon = 254;
                    break;
                    
            }
            int diapozoncopy = 0;
            diapozoncopy = diapozon;
            diapozon =  Convert.ToInt32(reshost) + diapozon-1;
            k = 0;
            for(int i=sMask.Length-1; sMask[i] != '.'; i--)
            {
                k=i;
            }
            String sMaskcopy = sMask;
            String sMaskcopy1 = sMask;
            sMask = sMask.Remove(k, sMask.Length-k);
            sMaskcopy = sMaskcopy.Remove(k, sMaskcopy.Length - k);
            sMaskcopy = sMaskcopy + diapozon;
            sMask = sMask + diapozoncopy;
            if (host > 30)
            {
                MessageBox.Show("Нету смысла");
            }
            else
            {
                textBox4.Text = sMask;
                textBox5.Text = sMaskcopy;
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
