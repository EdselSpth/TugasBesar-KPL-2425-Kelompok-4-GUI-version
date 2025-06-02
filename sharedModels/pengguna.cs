﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using TugasBesar_KPL_2425_Kelompok_4.Model;
using sharedModels;

namespace TugasBesar_KPL_2425_Kelompok_4.Model
{
    public class Pengguna
    {
        public string nama { get; set; }
        public JenisPengguna peran { get; set; }

        public Pengguna(string namaInput, JenisPengguna peranInput)
        {
            Debug.Assert(namaInput != null, "Nama tidak boleh null");
            if(namaInput == null)
            {
                throw new ArgumentNullException(nameof(namaInput), "Nama Pengguna Tidak Boleh Kosong!!!");
            }
            nama = namaInput;
            peran = peranInput;
        }

        public Pengguna()
        {
               
        }
    }
}
