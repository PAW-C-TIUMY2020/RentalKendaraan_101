﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_101.Models
{
    public partial class Customer
    {
        public int IdCustomer { get; set; }
        [Required(ErrorMessage = "Nama Customer tidak boleh kosong")]
        [DisplayName("Nama Customer")]
        public string NamaCustomer { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh diisi oleh angka")]
        [DisplayName("NIK")]
        [Required(ErrorMessage = "NIK tidak boleh kosong")]
        public string Nik { get; set; }
        [Required(ErrorMessage = "Alamat tidak boleh kosong")]
        public string Alamat { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh diisi oleh angka")]
        [Required(ErrorMessage = "No Hp tidak boleh kosong")]
        [DisplayName("No HP")]
        public string NoHp { get; set; }
        [DisplayName("Id Gender")]
        [Required(ErrorMessage = "Id Gender tidak boleh kosong")]
        public int? IdGender { get; set; }

        public Gender Gender { get; set; }
        [Required(ErrorMessage = "Tanggal peminjaman wajib diisi wajib diisi")]
        public Peminjaman Peminjaman { get; set; }
    }
}
