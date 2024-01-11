using SupermarketManagementApp.DTO;
using SupermarketManagementApp.Infrastructure;
using SupermarketManagementApp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementApp.BUS
{
    public class SupplierInvoiceBUS
    {
        private static SupplierInvoiceBUS instance;
        private readonly UnitOfWork unitOfWork;

        private SupplierInvoiceBUS()
        {
            unitOfWork = new UnitOfWork();
        }

        public static SupplierInvoiceBUS GetInstance()
        {
            if (instance == null)
            {
                instance = new SupplierInvoiceBUS();
            }
            return instance;
        }
        public async Task<Result<SupplierInvoice>> AddNewSupplierInvoice(SupplierInvoice supplierInvoice)
        {
            Result<SupplierInvoice> result = new Result<SupplierInvoice>();
            if(string.IsNullOrEmpty(supplierInvoice.SupplierName))
            {
                result.IsSuccess = false;
                result.ErrorMessage = "Please enter all required information";
                return result;
            }
            float capacity = supplierInvoice.SupplierInvoiceDetails.Sum(p => p.ProductQuantity * p.Product.UnitConversion * p.Product.ProductCapacity);
            var listInventory = await unitOfWork.InventoryDetailRepositoryDAO.GetAll();
            float capacityInvetory = 0;
            foreach (var item in listInventory)
            {
                capacity += item.ProductQuantity * item.Product.ProductCapacity;
            }
            if (StaticGlobal.SYSTEM_CAPACITY-capacityInvetory < capacity)
            {
                result.IsSuccess = false;
                result.ErrorMessage = "Inventory is not enough";
                return result;
            }
            try
            {
                result.Data = await unitOfWork.SupplierInvoiceRepositoryDAO.Add(supplierInvoice);
                result.ErrorMessage = string.Empty;
                result.IsSuccess = true;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }
        public async Task<Result<IEnumerable<SupplierInvoice>>> getAllSupplierInvoice()
        {
            Result<IEnumerable<SupplierInvoice>> result = new Result<IEnumerable<SupplierInvoice>> ();
            try
            {
                result.Data = await unitOfWork.SupplierInvoiceRepositoryDAO.GetAll();
                result.ErrorMessage = string.Empty;
                result.IsSuccess = true;
            }
            catch(Exception ex)
            {
                result.IsSuccess = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }
        public async Task<Result<SupplierInvoice>> getSupplierInvoiceByID(long id)
        {
            Result<SupplierInvoice> result = new Result<SupplierInvoice>();
            try
            {
                result.Data = await unitOfWork.SupplierInvoiceRepositoryDAO.FindByID(id);
                result.ErrorMessage = string.Empty;
                result.IsSuccess = true;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }
    }
}
