using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppFakeStoreApi.Models
{
    internal class ResponseProduct: CreateProduct
    {
        public int Id { get; set; }
    }
}
