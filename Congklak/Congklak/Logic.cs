using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Congklak
{
    class Logic
    {
        private int[] lubang = new int[17];
        static int MainLagi;
        private int Berakhir = 0;
        public int PilihanCPU;
        public int posisiBola;

        //Mendefinisikan kondis awal permainan
        public void KondisiAwal()
        {
            for (int i = 1; i < 17; i++)
            {
                if (i != 8 && i != 16)
                {
                    lubang[i] = 7;
                }
                else
                {
                    lubang[i] = 0;
                }
            }
        }

        /*Mengembalikan nilai pada tiap lubang*/
        public int GetLubang1()
        {
            return lubang[1];
        }

        public int GetLubang2()
        {
            return lubang[2];
        }

        public int GetLubang3()
        {
            return lubang[3];
        }

        public int GetLubang4()
        {
            return lubang[4];
        }

        public int GetLubang5()
        {
            return lubang[5];
        }

        public int GetLubang6()
        {
            return lubang[6];
        }

        public int GetLubang7()
        {
            return lubang[7];
        }

        public int GetLubang8()
        {
            return lubang[8];
        }

        public int GetLubang9()
        {
            return lubang[9];
        }

        public int GetLubang10()
        {
            return lubang[10];
        }

        public int GetLubang11()
        {
            return lubang[11];
        }

        public int GetLubang12()
        {
            return lubang[12];
        }

        public int GetLubang13()
        {
            return lubang[13];
        }

        public int GetLubang14()
        {
            return lubang[14];
        }

        public int GetLubang15()
        {
            return lubang[15];
        }

        public int GetLubang16()
        {
            return lubang[16];
        }

        

        public int nilaiTerbesar()
        {
            int terbesar = lubang[9];
            int pilih = 9;
            for (int a = 10; a <= 15; a++)
            {
                if (terbesar < lubang[a])
                {
                    terbesar = lubang[a];
                    pilih = a;
                }
            }
            return pilih;
        }

        
        public int Pilihancomp()
        {
            return PilihanCPU;
        }

        //Perpindahan biji congklak
        public int SetPerubahanNilai(int _posisi, int _isi, int _pemain)
        {
            
            MainLagi = 0;
            lubang[_posisi] = 0;
            if (_pemain == 1) //Putaran untuk pemain sebelah kanan
            {
                while (_isi > 0)
                {
                    _posisi++;
                    if (_posisi > 16) //Kembali ke lubang 1 
                    {
                        _posisi = 1;
                    }
                    if (_posisi != 16)
                    {
                        lubang[_posisi] += 1;
                        _isi--;
                    }
                    posisiBola = _posisi;
                    nilaiPosisi();
                    return _posisi;
                }
                if (lubang[_posisi] > 1 && (_posisi != 8)) //terus melanjutkan giliran main
                {
                    SetPerubahanNilai(_posisi, lubang[_posisi], _pemain);
                }
                else if (_posisi == 8)
                {
                    MainLagi = 1;
                }
                else
                {
                    if (lubang[_posisi] == 1)
                    {
                        setTembakLubang(_posisi, _pemain);
                    }
                }
            }
            else //Putaran untuk pemain sebelah kiri
            {
                while (_isi > 0)
                {
                    _posisi++;
                    if (_posisi > 16) //kembali ke lubang 1
                    {
                        _posisi = 1;
                    }
                    if (_posisi != 8)
                    {
                        lubang[_posisi] += 1;
                        _isi--;
                    }
                    return _posisi;
                }
                if (lubang[_posisi] > 1 && (_posisi != 16))
                {
                    //sound di hapus dulu
                    SetPerubahanNilai(_posisi, lubang[_posisi], _pemain);
                }
                else if (_posisi == 16)
                {
                    MainLagi = 1;
                }
                else
                {
                    if (lubang[_posisi] == 1)
                    {
                        setTembakLubang(_posisi, _pemain);
                    }
                }
            }
            return _posisi;
        }

        public int nilaiPosisi()
        {
            return posisiBola;
        }

        public void setTembakLubang(int _posisi, int _pemain)
        {
            if (_pemain == 1)
            {
                if ((_posisi == 1) && (lubang[_posisi + 14] != 0))
                {
                    lubang[8] += (lubang[_posisi] + lubang[_posisi + 14]);
                    lubang[_posisi] = 0;
                    lubang[_posisi + 14] = 0;
                }
                else if ((_posisi == 2) && (lubang[_posisi + 12] != 0))
                {
                    lubang[8] += (lubang[_posisi] + lubang[_posisi + 12]);
                    lubang[_posisi] = 0;
                    lubang[_posisi + 12] = 0;
                }
                else if ((_posisi == 3) && (lubang[_posisi + 10] != 0))
                {
                    lubang[8] += (lubang[_posisi] + lubang[_posisi + 10]);
                    lubang[_posisi] = 0;
                    lubang[_posisi + 10] = 0;
                }
                else if ((_posisi == 4) && (lubang[_posisi + 8] != 0))
                {
                    lubang[8] += (lubang[_posisi] + lubang[_posisi + 8]);
                    lubang[_posisi] = 0;
                    lubang[_posisi + 8] = 0;
                }
                else if ((_posisi == 5) && (lubang[_posisi + 6] != 0))
                {
                    lubang[8] += (lubang[_posisi] + lubang[_posisi + 6]);
                    lubang[_posisi] = 0;
                    lubang[_posisi + 6] = 0;
                }
                else if ((_posisi == 6) && (lubang[_posisi + 4] != 0))
                {
                    lubang[8] += (lubang[_posisi] + lubang[_posisi + 4]);
                    lubang[_posisi] = 0;
                    lubang[_posisi + 4] = 0;
                }
                else if ((_posisi == 7) && (lubang[_posisi + 2] != 0))
                {
                    lubang[8] += (lubang[_posisi] + lubang[_posisi + 2]);
                    lubang[_posisi] = 0;
                    lubang[_posisi + 2] = 0;
                }
            }
            else
            {
                if ((_posisi == 9) && (lubang[_posisi - 2] != 0))
                {
                    lubang[16] += (lubang[_posisi] + lubang[_posisi - 2]);
                    lubang[_posisi] = 0;
                    lubang[_posisi - 2] = 0;
                }
                else if ((_posisi == 10) && (lubang[_posisi - 4] != 0))
                {
                    lubang[16] += (lubang[_posisi] + lubang[_posisi - 4]);
                    lubang[_posisi] = 0;
                    lubang[_posisi - 4] = 0;
                }
                else if ((_posisi == 11) && (lubang[_posisi - 6] != 0))
                {
                    lubang[16] += (lubang[_posisi] + lubang[_posisi - 6]);
                    lubang[_posisi] = 0;
                    lubang[_posisi - 6] = 0;
                }
                else if ((_posisi == 12) && (lubang[_posisi - 8] != 0))
                {
                    lubang[16] += (lubang[_posisi] + lubang[_posisi - 8]);
                    lubang[_posisi] = 0;
                    lubang[_posisi - 8] = 0;
                }
                else if ((_posisi == 13) && (lubang[_posisi - 10] != 0))
                {
                    lubang[16] += (lubang[_posisi] + lubang[_posisi - 10]);
                    lubang[_posisi] = 0;
                    lubang[_posisi - 10] = 0;
                }
                else if ((_posisi == 14) && (lubang[_posisi - 12] != 0))
                {
                    lubang[16] += (lubang[_posisi] + lubang[_posisi - 12]);
                    lubang[_posisi] = 0;
                    lubang[_posisi - 12] = 0;
                }
                else if ((_posisi == 15) && (lubang[_posisi - 14] != 0))
                {
                    lubang[16] += (lubang[_posisi] + lubang[_posisi - 14]);
                    lubang[_posisi] = 0;
                    lubang[_posisi - 14] = 0;
                }
            }
        }

        public static int SetMain()
        {
            return MainLagi;
        }

        //public int setTurnPlayer()
        //{
        //    if ((Form1.getTurn() % 2) == 0)
        //        return 2;
        //    else
        //        return 1;
        //}

        public Boolean ApakahGameBerakhir()
        {
            if ((lubang[1] == 0) && (lubang[2] == 0) && (lubang[3] == 0) && (lubang[4] == 0) &&
                (lubang[5] == 0) && (lubang[6] == 0) && (lubang[7] == 0))
            {
                Berakhir = 1;
            }
            else if ((lubang[9] == 0) && (lubang[10] == 0) && (lubang[11] == 0) && (lubang[12] == 0) &&
                (lubang[13] == 0) && (lubang[14] == 0) && (lubang[15] == 0))
            {
                Berakhir = 1;
            }

            if (Berakhir == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
