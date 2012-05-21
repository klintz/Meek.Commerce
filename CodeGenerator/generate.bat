set connectionstring="Data Source=.\ALPHA;Initial Catalog=Meek.Commerce.DEMO;Integrated Security=True"
set namespace="Meek.Commerce.Framework.Model"
set language="CSharp"
set outputobjectlayer="output\Entities.cs"
set outputssdl="output\Meek.Commerce.ssdl"
set outputcsdl="output\Meek.Commerce.csdl"
set outputmsl="output\Meek.Commerce.msl"
set outputview="output\View.cs"
set entitycontainer="DataContext"

EdmGen /mode:fullgeneration /connectionstring:%connectionstring% /namespace:%namespace% /language:%language% /outobjectlayer:%outputobjectlayer% /outssdl:%outputssdl% /outcsdl:%outputcsdl% /outmsl:%outputmsl% /outviews:%outputview% /entitycontainer:%entitycontainer% /nologo

pause