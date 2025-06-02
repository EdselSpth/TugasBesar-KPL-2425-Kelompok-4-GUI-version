﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TugasBesar_KPL_2425_Kelompok_4.GarbageCollectionSchedule;

namespace TugasBesar_KPL_2425_Kelompok_4.UserProgram
{
    class Kurir
    {
        public static void KurirProgram()
        {
            try
            {
                int pilihanuser = 999;
                while (pilihanuser != 2)
                {
                    Menu.menuKurir();
                    Console.Write("Pilih Menu: ");
                    pilihanuser = Convert.ToInt32(Console.ReadLine());
                    Menu.header();
                    switch (pilihanuser)
                    {
                        case 1:
                            jadwalService.ViewJadwal();
                            break;
                        case 2:
                            Console.WriteLine("Terima kasih sudah menggunakan aplikasi");
                            break;
                        default:
                            Console.WriteLine("Pilihan tidak tersedia");
                            break;

                    }
                }
            }
            catch (Exception ex) {

                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
