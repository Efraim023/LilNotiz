Visual Studio 2022-vel lehet elindítani a "WebApplication1.sln" elemre kattintva.
A Package manager consoleba fel kell vinni pár parancsot, miután a connectionstring be van állítva helyesen.
Az appsetting.json fájlba a server-t kell megadni,amely az MSSQL-ben megtalálható Server Név mellett van. A jelszó ha van, illetve felhasználónév, akkor azokat is át kell írni.
Ha ez meg van, akkor a következő lépés a migráció. A Package Manager Consoleba beírjuk ezeket:
Add-Migration Initial -Context BejelentkezesDbContext
Add-Migration Initial -Context NotizDbContext
Update-Database -Context BejelentkezesDbContext
Update-Database -Context NotizDbContext
Ezek után el is tudjuk indítani a projektet.
