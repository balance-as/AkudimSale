using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    using WSItemList;

    class ItemListClass
    {
//        private DataTable dtItems = new DataTable();
//        private DataTable dtSearchItems = new DataTable();

        public void InitItemDataTable(ref DataTable dtItems, ref DataTable dtSearchItems)
        {
            dtSearchItems.Clear();
            dtSearchItems.Columns.Clear();
            dtSearchItems.Columns.Add(("Varedata"), typeof(string));

            dtItems.Clear();
            dtItems.Columns.Clear();
            dtItems.Columns.Add(("Varenr."), typeof(string));
            //dtItems.PrimaryKey[0] = dtItems.Columns[0];
            dtItems.Columns.Add(("Beskrivelse"), typeof(string));
            dtItems.Columns.Add(("Pris"), typeof(decimal));
            dtItems.Columns.Add(("Enhed"), typeof(string));
            dtItems.Columns.Add(("Lager"), typeof(string));
            dtItems.Columns.Add(("Stregkode"), typeof(string));
        }

        public string GetItemData(string FromItemNo, int ReadMax, ref DataTable dtItems, ref DataTable dtSearchItems)
        {
            ItemListPage_Service itemlistpageservice = new ItemListPage_Service();
            itemlistpageservice.UseDefaultCredentials = true;

            List<ItemListPage_Filter> ItemFilterArray = new List<ItemListPage_Filter>();

            ItemListPage_Filter ItemBlockedFilter = new ItemListPage_Filter();
            ItemBlockedFilter.Field = ItemListPage_Fields.Blocked;
            ItemBlockedFilter.Criteria = false.ToString();
            ItemFilterArray.Add(ItemBlockedFilter);

            ItemListPage_Filter ItemSanaFilter = new ItemListPage_Filter();
            ItemSanaFilter.Field = ItemListPage_Fields.Visible_in_Webshop;
            ItemSanaFilter.Criteria = true.ToString();
            ItemFilterArray.Add(ItemSanaFilter);

            ItemListPage_Filter ItemLocationFilter = new ItemListPage_Filter();
            ItemLocationFilter.Field = ItemListPage_Fields.Location_Filter;
            ItemLocationFilter.Criteria = Globals.theLocation;
            ItemFilterArray.Add(ItemLocationFilter);

            ItemListPage_Filter ItemNoFilter = new ItemListPage_Filter();
            ItemNoFilter.Field = ItemListPage_Fields.No;
            ItemNoFilter.Criteria = FromItemNo;
            ItemFilterArray.Add(ItemNoFilter);

            ItemListPage[] Result = itemlistpageservice.ReadMultiple(ItemFilterArray.ToArray(), "", ReadMax);

            if (Result.Count() > 0)
            {
                var cellValue = "";
                if (dtItems.Rows.Count > 0)
                    cellValue = dtItems.Rows[dtItems.Rows.Count -1][0].ToString();
                dtSearchItems.Rows.Add(new object[] { string.Format("{0} {1} {2}", "", "", "") });
                foreach (var item in Result)
                {
                    if (!item.No.Equals(cellValue))
                    {
                        dtItems.Rows.Add(new object[] { item.No, item.Description, item.Unit_Price, item.Sales_Unit_of_Measure, item.Inventory, item.Barcode_Base_UoM });
                        dtSearchItems.Rows.Add(new object[] { string.Format("{0} {1} {2}", item.No, item.Description, item.Barcode_Base_UoM) });
                    }
                }
                return Result.Last().No;
            }
            else
                return "";
        }
    }
}
