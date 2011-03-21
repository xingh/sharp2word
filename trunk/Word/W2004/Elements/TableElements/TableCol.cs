namespace Word.W2004.Elements.TableElements
{
    public class TableCol : ITableItemStrategy
    {
        public string getTop()
        {
            return "\n		<w:tr wsp:rsidR=\"00505659\" wsp:rsidRPr=\"00505659\">";
        }

        public string getMiddle()
        {
            string td =
                "                <w:tc> "
                + "\n                    <w:tcPr> "
                + "\n                        <w:tcW w:w=\"4258\" w:type=\"dxa\"/> "
                + "\n                    </w:tcPr> "
                + "\n                    <w:p wsp:rsidR=\"00505659\" wsp:rsidRPr=\"00505659\" wsp:rsidRDefault=\"00505659\"> "
                + "\n                        <w:r wsp:rsidRPr=\"00505659\"> "
                + "\n                            <w:t>{value}</w:t> "
                + "\n                        </w:r> "
                + "\n                    </w:p> "
                + "\n                </w:tc> "
                ;
            return td;
        }

        public string getBottom()
        {
            return "\n		</w:tr>";
        } 
    }
}