using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SQLiteDb
{

    public class Categories
    {
        public int CategoryID { get; set; }
        public string Category { get; set; }

        public Categories(int categoryID, string category)
        {
            CategoryID = categoryID;
            Category = category;
        }
    }

    public class Products
    {
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public string Descripcion { get; set; }
        public int Price { get; private set; }
        public int Stock { get; set; }

        public Products(int productID, int categoryID, string descripcion, int price, int stock)
        {
            ProductID = productID;
            CategoryID = categoryID;
            Descripcion = descripcion;
            Price = price;
            Stock = stock;
        }
    }

    public class Payment
    {
        public int TransactionID { get; set; }
        public string TransactionType { get; set; }

        public Payment(int transactionID, string transactionType)
        {
            TransactionID = transactionID;
            TransactionType = transactionType;
        }
    }


    public class Usuario
        {
            public int UserID { get; set; }
            public int RoleID { get; set; }      
            public string Username { get; set; }
            public int Password { get; set; }

            public Usuario(int userID, int roleID, string username, int password)
            {
                UserID = userID;
                RoleID = roleID;
                Username = username;
                Password = password;
            }
        }

    public class Sales
    {
        public int RecordID { get; set; }
        public string Date { get; set; }
        public int UserID { get; set; }
        public int TranscactionType { get; set; }
        

        public Sales(int recordID, string date, int userID, int transcactionType)
        {
            RecordID = recordID;
            Date = date;
            UserID = userID;
            TranscactionType = transcactionType;
            
        }
    }

    public class SalesByProduct
    {
        public int SaleID { get; set; }
        public string Product { get; set; }
        public int SoldQty { get; set; }
        public int Price { get; set; }

        public SalesByProduct(int saleID, string product, int soldQty, int price)
        {
            SaleID = saleID;
            Product = product;
            SoldQty = soldQty;
            Price = price;
        }
    }

    public class SalesFecha
    {
        public string Producto { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public SalesFecha(string producto, int quantity, decimal price)
        {
            Producto = producto;
            Quantity = quantity;
            Price = price;
        }
    }


    public partial class SQLiteConn
    {
        public List<Usuario> GetUsername()
        {
            List<Usuario> aux = new List<Usuario>();
            using (SQLiteRecordSet rs = ExecuteQuery($"SELECT  user_id, role_id, login_name, password FROM users;  "))
            {
                while (rs.NextRecord())
                {
                    int userid = rs.GetInt32("user_id");
                    int roleid = rs.GetInt32("role_id");
                    string username = rs.GetString("login_name");
                    int password = rs.GetInt32("password");

                    aux.Add(new Usuario(userid, roleid, username, password));
                }

            }
            return aux;
        }

        public int GetPassword(int Usuario)
        {
            int password = 0;

            string query = $"SELECT password FROM users WHERE user_id = '{Usuario}'; ";
            using (SQLiteRecordSet rs = ExecuteQuery(query))
            {
                while (rs.NextRecord())
                {
                    int passw = rs.GetInt32("password");

                    return passw;
                }

            }


            return password;
        }

        public int GetRole(int pass)
        {
            int roleid = 3;

            string query = $"SELECT role_id FROM users WHERE password = '{pass}'; ";
            using (SQLiteRecordSet rs = ExecuteQuery(query))
            {
                while (rs.NextRecord())
                {
                    int role = rs.GetInt32("role_id");

                    return role;
                }

            }


            return roleid;
        }

        public List<Categories> GetCategories()
        {
            List<Categories> categories = new List<Categories>();

            string query = $"SELECT * FROM categories ORDER BY id";

            using (SQLiteRecordSet rs = ExecuteQuery(query))
            {
                while (rs.NextRecord())
                {
                    int categoryID = rs.GetInt32("id");
                    string category = rs.GetString("category");

                    categories.Add(new Categories(categoryID, category));
                }
            }

            return categories;
        }

        public void DeleteCategory(int id)
        {

            string query = $"DELETE FROM categories WHERE id= {id}";
            ExecuteNonQuery(query);
        }

        public void AddCategory(Categories c)
        {

            string query = $"INSERT INTO categories id = {c.CategoryID}, category = {c.Category} ";
            ExecuteNonQuery(query);
        }


        public List<Products> GetProducts()
        {
            List<Products> products = new List<Products>();

            string query = $"SELECT * FROM products ORDER BY product_id";

            using (SQLiteRecordSet rs = ExecuteQuery(query))
            {
                while (rs.NextRecord())
                {
                    int productID = rs.GetInt32("product_id");
                    int categoryID = rs.GetInt32("category_id");
                    string descripcion = rs.GetString("description");
                    int price = rs.GetInt32("price");
                    int stock = rs.GetInt32("qty");

                    products.Add(new Products(productID, categoryID, descripcion, price, stock));
                }
            }

            return products;
        }

        public List<Products> GetProductsByID(int id)
        {
            List<Products> products = new List<Products>();

            string query = $"SELECT * FROM products ORDER BY product_id = {id}";

            using (SQLiteRecordSet rs = ExecuteQuery(query))
            {
                while (rs.NextRecord())
                {
                    int productID = rs.GetInt32("product_id");
                    int categoryID = rs.GetInt32("category_id");
                    string descripcion = rs.GetString("description");
                    int price = rs.GetInt32("price");
                    int stock = rs.GetInt32("qty");

                    products.Add(new Products(productID, categoryID, descripcion, price, stock));
                }
            }

            return products;
        }

        public Products GetProductsByName(string name)
        {


            string query = $"SELECT * FROM products WHERE description = '{name}'";

            using (SQLiteRecordSet rs = ExecuteQuery(query))
            {
                while (rs.NextRecord())
                {
                    int productID = rs.GetInt32("product_id");
                    int categoryID = rs.GetInt32("category_id");
                    string descripcion = rs.GetString("description");
                    int price = rs.GetInt32("price");
                    int stock = rs.GetInt32("qty");

                    return new Products(productID, categoryID, descripcion, price, stock);
                }

            }

            return null;
        }

        public void UpdateProduct(int id, Products p)
        {
            string query = $"UPDATE product SET qty {p.Stock}, price {p.Price} WHERE id = {id}";
            ExecuteNonQuery(query);
        }

        public void DeleteProduct(int id)
        {

            string query = $"DELETE FROM product WHERE id= {id}";
            ExecuteNonQuery(query);
        }

        public void AddProduct(Products p)
        {

            string query = $"INSERT INTO products product_id = {p.ProductID}, category_id={p.CategoryID}, descripcion = {p.Descripcion}" +
                $"price = {p.Price}, stock = {p.Stock} ";
            ExecuteNonQuery(query);
        }


        public List<Sales> GetSalesByDate(string dates)
        {
            List<Sales> sales = new List<Sales>();

            string query = $"SELECT * FROM sales_record ORDER BY date_sale = {dates}";

            using (SQLiteRecordSet rs = ExecuteQuery(query))
            {
                while (rs.NextRecord())
                {
                    int recordID = rs.GetInt32("record_id");
                    string date = rs.GetString("date_sale");
                    int userID = rs.GetInt32("by_user");
                    int transcactionType = rs.GetInt32("transaction_type");
                    


                    sales.Add(new Sales(recordID, date, userID, transcactionType));
                }
            }

            return sales;
        }

        public List<Sales> GetSales()
        {
            List<Sales> sales = new List<Sales>();

            string query = $"SELECT * FROM sales_record ";

            using (SQLiteRecordSet rs = ExecuteQuery(query))
            {
                while (rs.NextRecord())
                {
                    int recordID = rs.GetInt32("record_id");
                    string date = rs.GetString("date_sale");
                    int userID = rs.GetInt32("by_user");
                    int transcactionType = rs.GetInt32("transaction_type");
                    


                    sales.Add(new Sales(recordID, date, userID, transcactionType));
                }
            }

            return sales;
        }

        public List<Sales> GetSalesByUser(int id)
        {
            List<Sales> sales = new List<Sales>();

            string query = $"SELECT * FROM sales_record ORDER BY by_user = {id} ";

            using (SQLiteRecordSet rs = ExecuteQuery(query))
            {
                while (rs.NextRecord())
                {
                    int recordID = rs.GetInt32("record_id");
                    string date = rs.GetString("date_sale");
                    int userID = rs.GetInt32("by_user");
                    int transcactionType = rs.GetInt32("transaction_type");
                    

                    sales.Add(new Sales(recordID, date, userID, transcactionType));
                }
            }

            return sales;
        }

        public List<Sales> GetSalesByTransactionType(string ty)
        {
            List<Sales> sales = new List<Sales>();

            string query = $"SELECT * FROM sales_product ORDER BY transaction_type={ty}";

            using (SQLiteRecordSet rs = ExecuteQuery(query))
            {
                while (rs.NextRecord())
                {
                    int recordID = rs.GetInt32("record_id");
                    string date = rs.GetString("date_sale");
                    int userID = rs.GetInt32("by_user");
                    int transcactionType = rs.GetInt32("transaction_type");
                    

                    sales.Add(new Sales(recordID, date, userID, transcactionType));
                }
            }

            return sales;
        }

        public int GetSalesByRecord()
        {
            string query = $"SELECT record_id FROM sales_record WHERE record_id =(SELECT MAX(record_id) From sales_record)";
            using (SQLiteRecordSet rs = ExecuteQuery(query))
            {
                while (rs.NextRecord())
                {
                    return rs.GetInt32("record_id");
                }

                return 0;
            }

        }

        public int GetPrice()
        {
            string query = $"SELECT price FROM sales_product ";
            using (SQLiteRecordSet rs = ExecuteQuery(query))
            {
                while (rs.NextRecord())
                {
                    return rs.GetInt32("price");
                }

                return 0;
            }
        }

        public void AddSale(Sales s)
        {
            string query = $"INSERT INTO sales_record record_id = {s.RecordID}, date = {s.Date}" +
                $"user_id={s.UserID}, transaction_type = {s.TranscactionType}";
            ExecuteNonQuery(query);
        }

        public void AddSaleByP(SalesByProduct s)
        {
            string query = $"INSERT INTO sales_product sale_id = {s.SaleID}, product = {s.Product}" +
                $"qty_sold ={s.SoldQty}, price = {s.Price}";
            ExecuteNonQuery(query);
        }

        public void DeleteSale(int id)
        {

            string query = $"DELETE FROM sales_record WHERE record_id= {id}";
            ExecuteNonQuery(query);
        }

        public void DeleteSaleByProduct(int id)
        {

            string query = $"DELETE FROM sales_product WHERE sale_id= {id}";
            ExecuteNonQuery(query);
        }

        public List<Payment> GetPaymentType()
        {
            List<Payment> payment = new List<Payment>();

            string query = $"SELECT * FROM payment ";
            using (SQLiteRecordSet rs = ExecuteQuery(query))
            {
                while (rs.NextRecord())
                {
                    int transactionID = rs.GetInt32("transaction_id");
                    string transactionType = rs.GetString("type_transaction");
                    payment.Add(new Payment(transactionID, transactionType));
                }

            }
            return payment;
        }

        public void AñadirProduct(int cantidad, Products products, int cantidadactual)
        {
            string query = $"UPDATE products SET qty = {cantidad + cantidadactual} WHERE product_id = {products.ProductID}";
            ExecuteNonQuery(query);
        }

        public List<SalesFecha> GetProductBest()
        {
            List<SalesFecha> aux = new List<SalesFecha>();
            using (SQLiteRecordSet rs = ExecuteQuery($"SELECT p.description, SUM(sp.qty_sold ) AS vendido, SUM(sp.qty_sold* (p.price/100))AS ganancia FROM sales_record sr INNER JOIN sales_product sp ON (sr.record_id = sp.sale_id )" +
               "INNER JOIN products p ON(sp.product = p.product_id)  GROUP BY p.description ORDER BY MAX(sp.qty_sold)DESC LIMIT 1; "))
            {
                while (rs.NextRecord())
                {
                    string producto = rs.GetString("description");
                    int quantity = rs.GetInt32("vendido");
                    decimal price = rs.GetInt32("ganancia");


                    aux.Add(new SalesFecha(producto, quantity, price));
                }

            }
            return aux;
        }

        public List<SalesFecha> GetProductLow()
        {
            List<SalesFecha> aux = new List<SalesFecha>();
            using (SQLiteRecordSet rs = ExecuteQuery($"SELECT p.description, SUM(sp.qty_sold ) AS vendido, SUM(sp.qty_sold* (p.price/100))AS ganancia FROM sales_record sr INNER JOIN sales_product sp ON (sr.record_id = sp.sale_id )" +
                 "INNER JOIN products p ON(sp.product = p.product_id)  GROUP BY p.description ORDER BY MAX(sp.qty_sold)ASC LIMIT 1; "))
            {
                while (rs.NextRecord())
                {
                    string producto = rs.GetString("description");
                    int quantity = rs.GetInt32("vendido");
                    decimal price = rs.GetInt32("ganancia");


                    aux.Add(new SalesFecha(producto, quantity, price));
                }

            }
            return aux;
        }

        public List<SalesFecha> GetProductPricetop()
        {
            List<SalesFecha> aux = new List<SalesFecha>();
            using (SQLiteRecordSet rs = ExecuteQuery($"SELECT p.description, SUM(sp.qty_sold ) AS vendido, SUM(sp.qty_sold* (p.price/100))" +
                "AS ganancia FROM sales_record sr INNER JOIN sales_product sp ON (sr.record_id = sp.sale_id )" +
               "INNER JOIN products p ON(sp.product = p.product_id)  GROUP BY p.description ORDER BY SUM(sp.qty_sold * (p.price / 100))DESC LIMIT 1; "))
            {
                while (rs.NextRecord())
                {
                    string producto = rs.GetString("description");
                    int quantity = rs.GetInt32("vendido");
                    decimal price = rs.GetInt32("ganancia");


                    aux.Add(new SalesFecha(producto, quantity, price));
                }

            }
            return aux;
        }

        public List<SalesFecha> GetProductbadprice()
        {
            List<SalesFecha> aux = new List<SalesFecha>();
            using (SQLiteRecordSet rs = ExecuteQuery($"SELECT p.description, SUM(sp.qty_sold ) AS vendido, SUM(sp.qty_sold* (p.price/100))" +
                "AS ganancia FROM sales_record sr INNER JOIN sales_product sp ON (sr.record_id = sp.sale_id )" +
             "INNER JOIN products p ON(sp.product = p.product_id)  GROUP BY p.description ORDER BY SUM(sp.qty_sold * (p.price / 100))ASC LIMIT 1; "))
            {
                while (rs.NextRecord())
                {
                    string producto = rs.GetString("description");
                    int quantity = rs.GetInt32("vendido");
                    decimal price = rs.GetInt32("ganancia");


                    aux.Add(new SalesFecha(producto, quantity, price));
                }

            }
            return aux;
        }

        public int GetSalesTotal(int sale_id)
        {
            string query = $"SELECT SUM(sp.qty_sold* (p.price/ 100))AS ganancia FROM sales_record sr INNER JOIN sales_product sp ON(sr.record_id = sp.sale_id) " +
                $"INNER JOIN products p ON(sp.product = p.product_id)  WHERE sale_id = {sale_id}";
            using (SQLiteRecordSet rs = ExecuteQuery(query))
            {
                while (rs.NextRecord())
                {
                    return rs.GetInt32("sale_id");
                }

                return 0;
            }

        }
    }
}
