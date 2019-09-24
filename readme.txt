-Simple project!!
WEB API && MVC
  
  1.Using Microsoft Sql Server
    1.1 Two tables (dbo.Profesori,dbo.Lenda)
      1.1.1 dbo.Lenda foreign key(id_p) references dbo.Profesori(id_p)
    1.2 Two views (vw_Lendet,vw_Profesori)
  
  2.Implementing requests : Get,Post,Put,Delete
  
  3.API CONTROLLERS
    3.1 GetProfesoriController > from vwProfesori
    3.2 getlendaController > from vwLenda
    3.3 LendetController > from Lenda
    3.4 ProfesoriController > from Profesori
    
  4.MVC CONTROLLERS
    4.1 editController
      4.1.1 using HTML/CSS/JQUERY
            for editing data of Profesori table
    4.2 homecontroller
      4.2.1 using HTML/CSS/JQUERY
            for showing first page
    4.3 shfaqLendetController
      4.3.1 using HTML/CSS/JQUERY
        for showing vw_lenda
    4.4 ShfaqProfesoret  
      4.4.1 using HTML/CSS/JQUERY
      for showing vw_profesoret
    4.5 ShtoLendetController
      4.5.1  using HTML/CSS/JQUERY
      for adding new data on dbo.Lendet
    4.6  shtoProfesorController
      for adding new data on dbo.Profesoret
