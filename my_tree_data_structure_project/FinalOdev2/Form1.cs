using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalOdev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class BSTDugum
        {
            public BSTDugum sol;
            public int deger;
            public string konum;
            public BSTDugum sag;
        }
        BSTDugum kok;
        private void butonEkle_Click(object sender, EventArgs e)
        {
            int deger = Convert.ToInt32(ekleTextBox.Text);
            Ekle(deger);
            BSTDugum isaretci = kok;
            int duzey = yukseklikBul(isaretci);
            duzeyLabel2.Text = "Ağacın Düzeyi: " + duzey;
        }
        private void Ekle(int deger)
        {
            string sol = "sol";
            string sag = "sağ";
            BSTDugum yeni = new BSTDugum();
            yeni.deger = deger;
            if (kok == null)
            {
                kok = yeni;
                yeni.konum = "kök";
                ekleLabel.Text = yeni.deger + " düğümü eklendi";
            }
            else
            {
                BSTDugum isaretci = kok;
                while (true)
                {
                    if (deger > isaretci.deger)
                    {
                        yeni.konum += sag + ",";
                        if (isaretci.sag == null)
                        {
                            isaretci.sag = yeni;
                            ekleLabel.Text = yeni.deger + " düğümü eklendi";
                            break;
                        }
                        else
                        {
                            isaretci = isaretci.sag;
                        }
                    }
                    else if (deger < isaretci.deger)
                    {
                        yeni.konum += sol + ",";
                        if (isaretci.sol == null)
                        {
                            isaretci.sol = yeni;
                            ekleLabel.Text = yeni.deger + " düğümü eklendi";
                            break;
                        }
                        else
                        {
                            isaretci = isaretci.sol;
                        }
                    }
                    else if (deger == isaretci.deger)
                    {
                        MessageBox.Show("aynı değer eklenemez");
                        break;
                    }
                }
            }
        }

        private void bulButton_Click(object sender, EventArgs e)
        {
            int deger = 0;
            if (bulmaTextBox.Text != "")
            {
                deger = Convert.ToInt32(bulmaTextBox.Text);
            }
            Bul(deger);
        }
        public void Bul(int deger)
        {
            int solSayac = 1;
            int sagSayac = 1;
            BSTDugum isaretci = kok;
            while (true)
            {
                if (isaretci == null)
                {
                    MessageBox.Show("değer bulunamadı");
                    break;
                }
                else if (isaretci.deger == deger)
                {
                    if (sagSayac > solSayac)
                    {
                        duzeyLabel.Text = "Düğümün Düzeyi: " + sagSayac;
                        MessageBox.Show("Değer "+ sagSayac+". düzeyde bulundu");
                    }
                    else if (solSayac >= sagSayac)
                    {
                        duzeyLabel.Text = "Düğümün Düzeyi: " + solSayac;
                        MessageBox.Show("Değer " + solSayac + ". düzeyde bulundu");
                    }
                    
                    break;
                }
                else if (isaretci.deger < deger)
                {
                    sagSayac++;
                    isaretci = isaretci.sag;
                }
                else if (isaretci.deger > deger)
                {
                    solSayac++;
                    isaretci = isaretci.sol;
                }
            }
        }

        private void gosterButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = null;
            BSTDugum isaretci = kok;
            listele(isaretci);
        }

        private void listele(BSTDugum isaretci)
        {
            if (isaretci == null)
            {
                return;
            }
            richTextBox1.Text += isaretci.deger + " " + isaretci.konum + "\n";
            listele(isaretci.sol);
            listele(isaretci.sag);
        }

        int sayac;
        private void gosterButton2_Click(object sender, EventArgs e)
        {
            preorderBox.Text = null;
            postorderBox.Text = null;
            inorderBox.Text = null;
            yapraklarBox.Text = null;

            BSTDugum isaretci = kok;
            printPreOrder(isaretci);

            sayac = 0;
            isaretci = kok;
            int dugumSayisi = printPostOrder(isaretci);
            miktarBox.Text = dugumSayisi.ToString();

            isaretci = kok;
            printInOrder(isaretci);

            isaretci = kok;
            int yukseklik = yukseklikBul(isaretci);
            yukseklikBox.Text = (yukseklik - 1).ToString();

            isaretci = kok;
            int duzey = yukseklikBul(isaretci);
            duzeyLabel2.Text = "Ağacın Düzeyi: " + duzey;
        }

        private int yukseklikBul(BSTDugum isaretci)
        {
            if (isaretci == null)
            {
                return 0;
            }
            return Math.Max(yukseklikBul(isaretci.sol), yukseklikBul(isaretci.sag)) + 1;
        }

        private void printPreOrder(BSTDugum isaretci)
        {
            if (isaretci == null)
            {
                return;
            }
            preorderBox.Text += isaretci.deger + " ";
            if (isaretci.sol == null && isaretci.sag == null)
            {
                yapraklarBox.Text += isaretci.deger + " ";
            }
            printPreOrder(isaretci.sol);
            printPreOrder(isaretci.sag);
            
        }

        private int printPostOrder(BSTDugum isaretci)
        {
            if (isaretci == null)
            {
                return sayac;
            }
            printPostOrder(isaretci.sol);
            printPostOrder(isaretci.sag);
            postorderBox.Text += isaretci.deger + " ";
            sayac++;
            return sayac;
        }

        private void printInOrder(BSTDugum isaretci)
        {
            if (isaretci == null)
            {
                return;
            }
            printInOrder(isaretci.sol);
            inorderBox.Text += isaretci.deger + " ";
            printInOrder(isaretci.sag);
        }

        private void silButton_Click(object sender, EventArgs e)
        {
            int deger = Convert.ToInt32(silmeTextBox.Text);
            silmeLabel.Text = deger + " düğümü silindi";
            sil(kok, deger);
            

            BSTDugum isaretci = kok;
            int duzey = yukseklikBul(isaretci);
            duzeyLabel2.Text = "Ağacın Düzeyi: " + duzey;
        }

        private BSTDugum sil(BSTDugum kok, int deger)
        {
            if (kok == null)
            {
                return null;
            }
            if (kok.deger == deger)
            {
                if (kok.sol == null && kok.sag == null)
                {
                    return null;
                }
                if (kok.sag != null)
                {
                    kok.deger = min(kok.sag);
                    kok.sag = sil(kok.sag, min(kok.sag));
                    return kok;
                }
                if (kok.sol!=null)
                {
                    kok.deger = max(kok.sol);
                    kok.sol = sil(kok.sol, max(kok.sol));
                    return kok;
                }

            }
            if (kok.deger < deger)
            {
                kok.sag = sil(kok.sag, deger);
                return kok;
            }
            else
            {
                kok.sol = sil(kok.sol, deger);
                return kok;
            }
        }

        private int max(BSTDugum kok)
        {
            while (kok.sag != null)
            {
                kok = kok.sag;
            }
            return kok.deger;
        }

        private int min(BSTDugum kok)
        {
            while (kok.sol != null)
            {
                kok = kok.sol;
            }
            return kok.deger;
        }
    }
}
