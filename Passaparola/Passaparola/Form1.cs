using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlis = 0;

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "SONRAKİ";
            soruno++;
            this.Text = soruno.ToString();
            textBox1.Text = "";
            BtnHarf.BackColor = Color.Yellow;

            if (soruno == 1)
            {
                richTextBox1.Text = "Ülkemizin güney kısmındaki kıyı bölgesi?";
                BtnA.BackColor = Color.Yellow;
                BtnHarf.Text = "A";
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Yeşilliğiyle ünlü Marmara ilimiz?";
                BtnB.BackColor = Color.Yellow;
                BtnHarf.Text = "B";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Müslümanların kutsal günü?";
                BtnC.BackColor = Color.Yellow;
                BtnHarf.Text = "C";
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Karpuzuyla ünlü ilimiz?";
                BtnD.BackColor = Color.Yellow;
                BtnHarf.Text = "D";
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Yeni kelimesinin zıt anlamlısı?";
                BtnE.BackColor = Color.Yellow;
                BtnHarf.Text = "E";
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Padişahın emirlerinin yazılı hali?";
                BtnF.BackColor = Color.Yellow;
                BtnHarf.Text = "F";
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Dünya'nın ısı kaynağı?";
                BtnG.BackColor = Color.Yellow;
                BtnHarf.Text = "G";
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Öğrencilerin kötü karne getirince sıkıştığı nesne?";
                BtnH.BackColor = Color.Yellow;
                BtnHarf.Text = "H";
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Gülüyle ünlü ilimiz?";
                BtnI.BackColor = Color.Yellow;
                BtnHarf.Text = "I";
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Mersin'in diğer ismi?";
                BtnII.BackColor = Color.Yellow;
                BtnHarf.Text = "İ";
            }
            if (soruno == 11)
            {
                richTextBox1.Text = "Arkeri bir topluluk?";
                BtnJ.BackColor = Color.Yellow;
                BtnHarf.Text = "J";
            }
            if (soruno == 12)
            {
                richTextBox1.Text = "Malatya'nın meşhur meyvesi?";
                BtnK.BackColor = Color.Yellow;
                BtnHarf.Text = "K";
            }
            if (soruno == 13)
            {
                richTextBox1.Text = "Her yıl bahar aylarında düzenlenen meşhur çiçek festivali?";
                BtnL.BackColor = Color.Yellow;
                BtnHarf.Text = "L";
            }
            if (soruno == 14)
            {
                richTextBox1.Text = "Yılın üçüncü ayı?";
                BtnM.BackColor = Color.Yellow;
                BtnHarf.Text = "M";
            }
            if (soruno == 15)
            {
                richTextBox1.Text = "Üflemeli müzik aleti?";
                BtnN.BackColor = Color.Yellow;
                BtnHarf.Text = "N";
            }
            if (soruno == 16)
            {
                richTextBox1.Text = "Halk şairi?";
                BtnO.BackColor = Color.Yellow;
                BtnHarf.Text = "O";
            }
            if (soruno == 17)
            {
                richTextBox1.Text = "Çocukların pek sevmediği sebze?";
                BtnP.BackColor = Color.Yellow;
                BtnHarf.Text = "P";
            }
            if (soruno == 18)
            {
                richTextBox1.Text = "11 ayın sultanı?";
                BtnR.BackColor = Color.Yellow;
                BtnHarf.Text = "R";
            }
            if (soruno == 19)
            {
                richTextBox1.Text = "İngilizce'de yılan?";
                BtnS.BackColor = Color.Yellow;
                BtnHarf.Text = "S";
            }
            if (soruno == 20)
            {
                richTextBox1.Text = "Türkiye'nin megastarı?";
                BtnT.BackColor = Color.Yellow;
                BtnHarf.Text = "T";
            }
            if (soruno == 21)
            {
                richTextBox1.Text = "Ümit kelimesinin eş anlamlısı?";
                BtnU.BackColor = Color.Yellow;
                BtnHarf.Text = "U";
            }
            if (soruno == 22)
            {
                richTextBox1.Text = "Kahvaltısı ile ünlü ilimiz?";
                BtnV.BackColor = Color.Yellow;
                BtnHarf.Text = "V";
            }
            if (soruno == 23)
            {
                richTextBox1.Text = "Şimşek kelimesinin eş anlamlısı?";
                BtnY.BackColor = Color.Yellow;
                BtnHarf.Text = "Y";
            }
            if (soruno == 24)
            {
                richTextBox1.Text = "Ege bölgesinin meyvesi?";
                BtnZ.BackColor = Color.Yellow;
                BtnHarf.Text = "Z";
            }
        }

        public void dogruArtir()
        {
            dogru++;
            LblDogru.Text = dogru.ToString();
        }

        private void LblDogru_TextChanged(object sender, EventArgs e)
        {
            BtnHarf.BackColor = Color.Green;
        }

        private void LblYanlis_TextChanged(object sender, EventArgs e)
        {
            BtnHarf.BackColor = Color.Red;
        }

        public void yanlisArtir()
        {
            yanlis++;
            LblYanlis.Text = yanlis.ToString();
        }

        public void enter()
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    //Cevap 1
                    case 1:
                        if (textBox1.Text == "akdeniz")
                        {
                            BtnA.BackColor = Color.Green;
                            dogruArtir();
                        }
                        else
                        {
                            BtnA.BackColor = Color.Red;
                            yanlisArtir();
                        }
                        break;
                    //Cevap 2
                    case 2:
                        if (textBox1.Text == "bursa")
                        {
                            BtnB.BackColor = Color.Green;
                            dogruArtir();
                        }
                        else
                        {
                            BtnB.BackColor = Color.Red;
                            yanlisArtir();
                        }
                        break;
                    //Cevap 3
                    case 3:
                        if (textBox1.Text == "cuma")
                        {
                            BtnC.BackColor = Color.Green;
                            dogruArtir();
                        }
                        else
                        {
                            BtnC.BackColor = Color.Red;
                            yanlisArtir();
                        }
                        break;
                    //Cevap 4
                    case 4:
                        if (textBox1.Text == "diyarbakır")
                        {
                            BtnD.BackColor = Color.Green;
                            dogruArtir();
                        }
                        else
                        {
                            BtnD.BackColor = Color.Red;
                            yanlisArtir();
                        }
                        break;
                    //Cevap 5
                    case 5:
                        if (textBox1.Text == "eski")
                        {
                            BtnE.BackColor = Color.Green;
                            dogruArtir();
                        }
                        else
                        {
                            BtnE.BackColor = Color.Red;
                            yanlisArtir();
                        }
                        break;
                    //Cevap 6
                    case 6:
                        if (textBox1.Text == "ferman")
                        {
                            BtnF.BackColor = Color.Green;
                            dogruArtir();
                        }
                        else
                        {
                            BtnF.BackColor = Color.Red;
                            yanlisArtir();
                        }
                        break;
                    //Cevap 7
                    case 7:
                        if (textBox1.Text == "güneş")
                        {
                            BtnG.BackColor = Color.Green;
                            dogruArtir();
                        }
                        else
                        {
                            BtnG.BackColor = Color.Red;
                            yanlisArtir();
                        }
                        break;
                    //Cevap 8
                    case 8:
                        if (textBox1.Text == "halı")
                        {
                            BtnH.BackColor = Color.Green;
                            dogruArtir();
                        }
                        else
                        {
                            BtnH.BackColor = Color.Red;
                            yanlisArtir();
                        }
                        break;
                    //Cevap 9
                    case 9:
                        if (textBox1.Text == "ısparta")
                        {
                            BtnI.BackColor = Color.Green;
                            dogruArtir();
                        }
                        else
                        {
                            BtnI.BackColor = Color.Red;
                            yanlisArtir();
                        }
                        break;
                    //Cevap 10
                    case 10:
                        if (textBox1.Text == "içel")
                        {
                            BtnII.BackColor = Color.Green;
                            dogruArtir();
                        }
                        else
                        {
                            BtnII.BackColor = Color.Red;
                            yanlisArtir();
                        }
                        break;
                    //Cevap 11
                    case 11:
                        if (textBox1.Text == "jandarma")
                        {
                            BtnJ.BackColor = Color.Green;
                            dogruArtir();
                        }
                        else
                        {
                            BtnJ.BackColor = Color.Red;
                            yanlisArtir();
                        }
                        break;
                    //Cevap 12
                    case 12:
                        if (textBox1.Text == "kayısı")
                        {
                            BtnK.BackColor = Color.Green;
                            dogruArtir();
                        }
                        else
                        {
                            BtnK.BackColor = Color.Red;
                            yanlisArtir();
                        }
                        break;
                    //Cevap 13
                    case 13:
                        if (textBox1.Text == "lale")
                        {
                            BtnL.BackColor = Color.Green;
                            dogruArtir();
                        }
                        else
                        {
                            BtnL.BackColor = Color.Red;
                            yanlisArtir();
                        }
                        break;
                    //Cevap 14
                    case 14:
                        if (textBox1.Text == "mart")
                        {
                            BtnM.BackColor = Color.Green;
                            dogruArtir();
                        }
                        else
                        {
                            BtnM.BackColor = Color.Red;
                            yanlisArtir();
                        }
                        break;
                    //Cevap 15
                    case 15:
                        if (textBox1.Text == "ney")
                        {
                            BtnN.BackColor = Color.Green;
                            dogruArtir();
                        }
                        else
                        {
                            BtnN.BackColor = Color.Red;
                            yanlisArtir();
                        }
                        break;
                    //Cevap 16
                    case 16:
                        if (textBox1.Text == "ozan")
                        {
                            BtnO.BackColor = Color.Green;
                            dogruArtir();
                        }
                        else
                        {
                            BtnO.BackColor = Color.Red;
                            yanlisArtir();
                        }
                        break;
                    //Cevap 17
                    case 17:
                        if (textBox1.Text == "pırasa")
                        {
                            BtnP.BackColor = Color.Green;
                            dogruArtir();
                        }
                        else
                        {
                            BtnP.BackColor = Color.Red;
                            yanlisArtir();
                        }
                        break;
                    //Cevap 18
                    case 18:
                        if (textBox1.Text == "ramazan")
                        {
                            BtnR.BackColor = Color.Green;
                            dogruArtir();
                        }
                        else
                        {
                            BtnR.BackColor = Color.Red;
                            yanlisArtir();
                        }
                        break;
                    //Cevap 19
                    case 19:
                        if (textBox1.Text == "snake")
                        {
                            BtnS.BackColor = Color.Green;
                            dogruArtir();
                        }
                        else
                        {
                            BtnS.BackColor = Color.Red;
                            yanlisArtir();
                        }
                        break;
                    //Cevap 20
                    case 20:
                        if (textBox1.Text == "tarkan")
                        {
                            BtnT.BackColor = Color.Green;
                            dogruArtir();
                        }
                        else
                        {
                            BtnT.BackColor = Color.Red;
                            yanlisArtir();
                        }
                        break;
                    //Cevap 21
                    case 21:
                        if (textBox1.Text == "umut")
                        {
                            BtnU.BackColor = Color.Green;
                            dogruArtir();
                        }
                        else
                        {
                            BtnU.BackColor = Color.Red;
                            yanlisArtir();
                        }
                        break;
                    //Cevap 22
                    case 22:
                        if (textBox1.Text == "van")
                        {
                            BtnV.BackColor = Color.Green;
                            dogruArtir();
                        }
                        else
                        {
                            BtnV.BackColor = Color.Red;
                            yanlisArtir();
                        }
                        break;
                    //Cevap 23
                    case 23:
                        if (textBox1.Text == "yıldırım")
                        {
                            BtnY.BackColor = Color.Green;
                            dogruArtir();
                        }
                        else
                        {
                            BtnY.BackColor = Color.Red;
                            yanlisArtir();
                        }
                        break;
                    //Cevap 24
                    case 24:
                        if (textBox1.Text == "zeytin")
                        {
                            BtnZ.BackColor = Color.Green;
                            dogruArtir();
                        }
                        else
                        {
                            BtnZ.BackColor = Color.Red;
                            yanlisArtir();
                        }
                        break;
                }
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
