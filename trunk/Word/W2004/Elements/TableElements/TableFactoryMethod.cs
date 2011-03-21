namespace Word.W2004.Elements.TableElements
{
    /// <summary>
    ///   Here is the logic to decide which instance create and return
    /// </summary>
    public class TableFactoryMethod
    {
        private static TableFactoryMethod instance;

        private TableFactoryMethod()
        {
        }

        public static TableFactoryMethod getInstance()
        {
            return instance ?? (instance = new TableFactoryMethod());
        }

        public static ITableItemStrategy getTableItem(TableEle tableEle)
        {
            if (tableEle == null)
            {
                return null;
            }

            return getTableEle(tableEle);
        }

        private static ITableItemStrategy getTableEle(TableEle tableEle)
        {
            if (tableEle.Value.Equals("tableDef"))
            {
                return new TableDefinition();
            }
            else if (tableEle.Value.Equals("th"))
            {
                return new TableHeader();
            }
            else if (tableEle.Value.Equals("td"))
            {
                return new TableCol();
            }
            else
            {
                //if (tableEle.getValue().equals("tf")) {
                return new TableFooter();
            }
        }
    }
}