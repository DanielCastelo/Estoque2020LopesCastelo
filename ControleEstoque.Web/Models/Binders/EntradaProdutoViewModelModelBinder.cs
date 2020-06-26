﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
//41
namespace ControleEstoque.Web.Models
{
    public class EntradaProdutoViewModelModelBinder : DefaultModelBinder
    {
        public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            if (bindingContext == null)
            {
                throw new ArgumentNullException(nameof(bindingContext));
            }

            var valores = controllerContext.HttpContext.Request.Form;

            var ret = new EntradaProdutoViewModel() { Produtos = new Dictionary<int, int>() };

            try
            {
                ret.Data = DateTime.ParseExact(valores.Get("data"), "yyyy-MM-dd", null);

                if (!string.IsNullOrEmpty(valores.Get("produtos")))
                {
                    var produtos = JsonConvert.DeserializeObject<List<dynamic>>(valores.Get("produtos"));

                    foreach (var produto in produtos)
                    {
                        ret.Produtos.Add((int)produto.IdProduto, (int)produto.Quantidade);
                    }
                };
            }
            catch
            {
            }

            return ret;
        }
    }
}