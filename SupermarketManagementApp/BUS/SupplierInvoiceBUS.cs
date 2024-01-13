using SupermarketManagementApp.DTO;
using SupermarketManagementApp.Infrastructure;
using SupermarketManagementApp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public async Task<Result<SupplierInvoice>> AddNewSupplierInvoice(Dictionary<string, SupplierInvoiceDetail> productDictionary, string name )
        {

            Result<SupplierInvoice> result = new Result<SupplierInvoice>();
            List<InventoryDetail> inventoryDetails = new List<InventoryDetail>();
            try
            {
                if (string.IsNullOrEmpty(name))
                {
                    result.IsSuccess = false;
                    result.ErrorMessage = "Please enter all required information";
                    return result;
                }

                List<SupplierInvoiceDetail> supplierInvoiceDetails = new List<SupplierInvoiceDetail>();
                if (productDictionary.Count > 0)
                {
                    foreach (var kval in productDictionary)
                    {
                        if (kval.Value.Product == null)
                        {
                            result.IsSuccess = false;
                            result.ErrorMessage = "Please add all required information";
                            return result;
                        }
                        if (supplierInvoiceDetails.FirstOrDefault(p => p.Product.ProductName == kval.Value.Product.ProductName) != null)
                        {
                            string message = String.Format("There are duplicate product {0}", kval.Value.Product.ProductName);
                            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            result.IsSuccess = false;
                            result.ErrorMessage = message;
                            return result;
                        }
                        supplierInvoiceDetails.Add(kval.Value);
                    }
                }
                DTO.SupplierInvoice supplierInvoice = new DTO.SupplierInvoice();
                supplierInvoice.SupplierName = name;
                supplierInvoice.EmployeeID = GlobalVariable.LoggedAccount.EmployeeID;
                supplierInvoice.SupplierInvoiceDetails = supplierInvoiceDetails;
                foreach (SupplierInvoiceDetail supplierInvoiceDetail in supplierInvoice.SupplierInvoiceDetails)
                {
                    inventoryDetails.Add(new InventoryDetail() { ProductID = supplierInvoiceDetail.Product.ProductID, ProductQuantity = supplierInvoiceDetail.ProductQuantity * supplierInvoiceDetail.Product.UnitConversion});
                }
                float capacity = supplierInvoice.SupplierInvoiceDetails.Sum(p => p.ProductQuantity * p.Product.UnitConversion * p.Product.ProductCapacity);
                var listInventory = await unitOfWork.InventoryDetailRepositoryDAO.GetAll();
                float capacityInvetory = 0;
                foreach (var item in listInventory)
                {
                    capacity += item.ProductQuantity * item.Product.ProductCapacity;
                }
                if (StaticGlobal.SYSTEM_CAPACITY - capacityInvetory < capacity)
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
                    if(result.IsSuccess)
                    {
                        foreach (InventoryDetail invnetory in inventoryDetails)
                          await  unitOfWork.InventoryDetailRepositoryDAO.AddOrUpdate(invnetory);
                    }
                }
                catch (Exception ex)
                {
                    result.IsSuccess = false;
                    result.ErrorMessage = ex.Message;
                }
            }
            catch(Exception ex) {
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
