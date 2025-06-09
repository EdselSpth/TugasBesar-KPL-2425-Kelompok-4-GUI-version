using Microsoft.AspNetCore.Identity.Data;
using modelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TugasBesar_KPL_2425_Kelompok_4;
using TugasBesar_KPL_2425_Kelompok_4.Penarikan_Keuntungan;
using TugasBesar_KPL_2425_Kelompok_4.GarbageCollectionSchedule;
using static TugasBesar_KPL_2425_Kelompok_4.Penarikan_Keuntungan.StateBasedPenarikan;

namespace TugasBesar_KPL_2425_Kelompok_4.UserProgram
{
    class Admin
    {
        public static void adminProgram()
        {
            try
            {
                int menuInput = 9999;
                while (menuInput != 6)
                {                    
                    Menu.menuAdmin();
                    Console.Write("Pilih Menu : ");
                    menuInput = Convert.ToInt32(Console.ReadLine());
                    Menu.header();
                    switch (menuInput)
                    {
                        case 1:
                            
                            break;
                        case 2:
                            break;
                        case 3:
                            
                            break;
                        case 4:
                          
                            break;
                        case 5:
                            PenarikanAdmin.TampilkanDataPenarikanCustomer();
                            PenarikanState state = PenarikanState.MEMASUKKAN_DATA;
                            PenarikanAdmin.ProsesPenarikan(ref state);
                            break;
                        case 6:
                            Console.WriteLine("Terima kasih sudah menggunakan aplikasi\n");
                            break;
                        default:
                            Console.WriteLine("Pilihan tidak valid.\n");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error {ex.Message}");
            }
        }
        
        
       

    }
}
