﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControleEstoqueProduto.Web.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Informe o Usuário")]
        [Display(Name ="Usuário:")]
        public string Usuario { get; set; }

        [Required(ErrorMessage ="Informe a senha")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha:")]
        public string Senha { get; set; }

        [Display(Name = "Lembrar Me")]
        public bool LembrarMe { get; set; }
    }
}