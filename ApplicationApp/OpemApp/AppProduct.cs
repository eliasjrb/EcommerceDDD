using ApplicationApp.Interface;
using Domain.Interfaces.InterfaceProduct;
using Domain.Interfaces.InterfaceServices;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationApp.OpemApp
{
    public class AppProduct : InterfaceProtuctApp
    {
        IProduct _IProduct;
        IServiceProduct _IServiceProduct;
        public AppProduct(IProduct iProduct, IServiceProduct iServiceProduct)
        {
            _IProduct = iProduct;
            _IServiceProduct = iServiceProduct;
        }
        public async Task AddProduct(Produto produto)
        {
            await _IServiceProduct.AddProduct(produto);
        }

        public async Task UpdateProduct(Produto produto)
        {
            await _IServiceProduct.UpdateProduct(produto);
        }

        public async Task Add(Produto objeto)
        {
            await _IProduct.Add(objeto);
        }


        public async Task Delete(Produto objeto)
        {
            await _IProduct.Delete(objeto);
        }

        public async Task<Produto> GetEntityById(int id)
        {
           return await _IProduct.GetEntityById(id);
        }

        public async Task<List<Produto>> List()
        {
            return await _IProduct.List();
        }

        public async Task Update(Produto objeto)
        {
            await _IProduct.Update(objeto);
        }

        
    }
}
