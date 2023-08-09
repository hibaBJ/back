using AxiaBackend.DependancyInjection;
using AxiaBackend.Interfaces;
using AxiaBackend.Services;
using Microsoft.AspNetCore.Mvc;

namespace AxiaBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private IConsoleWriter _IConsoleWriter;
        private IAccessoireService _IAccessoireService;
        private IEmployeeService _IEmployeeService;
        private IGroupeService _IGroupeService;
        private ICongesService _ICongesService;
        private IPaiementService _IPaiementService;
        private IPointageService _IPointageService;
        private IObjectifsService _IObjectifsService;
        private ITacheService _ITacheService;
        private IRoleService _IRoleService;
        private ILogService _ILogService;
        private IAttachementService _IAttachmentService;
        private ITypeCongesService _ITypeCongesService;
        private IUserService _IUserService;
      

        public WeatherForecastController(ILogger<WeatherForecastController> logger,ITypeCongesService prITypeCongesService,
            IConsoleWriter prIConsoleWriter,IAccessoireService prIAccessoireService, IEmployeeService prIEmployeeService,IGroupeService prIGroupeService,
            ICongesService prICongesService,IPaiementService prIPaiementService,
            IPointageService prIPointageService,
            IObjectifsService prIObjectifsService,
            ITacheService prITacheService,IRoleService prIRoleService,
            ILogService prILogService,IAttachementService prIAttachmentService,
            IUserService prIUserService)
        {
            _logger = logger;
            _IConsoleWriter = prIConsoleWriter;
            _IAccessoireService = prIAccessoireService;
            _IEmployeeService = prIEmployeeService;
            _IGroupeService = prIGroupeService;
            _ICongesService = prICongesService;
            _IPaiementService= prIPaiementService;
            _IPointageService = prIPointageService;
            _IObjectifsService = prIObjectifsService;  
            _ITacheService = prITacheService;
            _IRoleService = prIRoleService;
            _ILogService = prILogService;
            _IAttachmentService=prIAttachmentService;
            _ITypeCongesService=prITypeCongesService;
            _IUserService=prIUserService;


        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
            
        {
            //dependancy injection
            //_IConsoleWriter.Write();

            /*GET*/

            //*Get Accessoires
            //List<Accessoires> lAccessoires = _IAccessoireService.GetAll();
            //List<Accessoires> lAccessoires = _IAccessoireService.GetByName("Mokhtar");

            //Get Employee
            //List<Employee> lEmployees = _IEmployeeService.GetAll();
            //List<Employee> lEmployees = _IEmployeeService.GetByName("Hiba");

            //Get Groupe
            // List<Groupe> lGroupe = _IGroupeService.GetAll();
            //List<Groupe> lGroupe= _IGroupeService.GetByName("GroupeA");

            // GetConges
            //List<Conges> lConges = _ICongesService.GetAll();
            // List<Conges>lConges = _ICongesService.GetByName("Wejdene");

            //Get Paiement 

            // List<Paiement> lPaiement = _IPaiementService.GetAll();
            // List<Paiement> lPaiement = _IPaiementService.GetByName("Abla");

            //Get Pointage

            //List<Pointage>lPointage=_IPointageService.GetAll();
            // List<Pointage> lPointages = _IPointageService.GetByName("Sarra");

            //Get Objectifs
            //List<Objectifs> lObjectifs=_IObjectifsService.GetAll();
            //List<Objectifs> lObjectifs = _IObjectifsService.GetByName("Application mobile");

            //Get Tache

            // List<Taches>lTache=_ITacheService.GetAll();
            //List<Taches> lTaches = _ITacheService.GetByName("modifier espaces des noms");

            //Get Role 
            //List<Role> lRole = _IRoleService.GetAll();
            //List<Role> lRole = _IRoleService.GetByName("Admin");

            //Get Log
            //List<Log>lLog=_ILogService.GetAll();
            //List<Log> lLog = _ILogService.GetByName("Modification des taches");

            //Get Attachements 

            //List<Attachements> lAttachement = _IAttachmentService.GetAll();
            // List<Attachements> lAttachement = _IAttachmentService.GetByName("Sarra");


            /* ADD*/

            //Add Accessoire

            //Accessoires lNewAccessoire = new Accessoires() { Id = '7', Employee = "Khawla", Intitule = "Serveur", CbModificateur = DateTime.Today, CbCreateur = "Wejdene" };
            //_IAccessoireService.Save(lNewAccessoire); 

            //Add Attachement

            //Attachements lNewAttachment = new Attachements() {Id="Fiche de paie",Employee="Houda",Attachement="Fiche de paie",CbCreateur="wejdene",CbModificateur=DateTime.Today};
            //_IAttachmentService.Save(lNewAttachment);

            //Add Conges
            //Conges lNewConges = new Conges() {Id='7',Employee="",Date_Debut=DateTime.Today,Date_Fin=DateTime.Today ,Nombre='5',CbCreateur="",CbModificateur=DateTime.Now};

            //_ICongesService.Save(lNewConges);

            //Add Employee

            // Employee lNewEmployee=new Employee() { Name="Chams",Telephone="55850460",Ville="Mseken",Email="chams@gmail.com",GroupeId='1',RoleId='3',CbCreateur="Wejdene",CbModificateur=DateTime.Now,Id='5'};
            //_IEmployeeService.Save(lNewEmployee);

            //Add Groupe
            //Groupe lNewGroupe = new Groupe() { CbCreateur = "Abla", CbModificateur = DateTime.Now, Id = '7', Name = "Groupe D", Specialite = "Marketing" };
            //_IGroupeService.Save(lNewGroupe);

            //Add Log
            //Log lNewLog = new Log() { Message = "modification des objectifs", CbCreateur = "Abla", CbModificateur = DateTime.Now, Table = "Objectifs", Date = DateTime.Today };
            //_ILogService.Save(lNewLog);

            //Add Objectifs
            //Objectifs lNewObjectifs = new Objectifs() { Id = '5', Projet = "projet mobile", objectifs = " terminer la partie client ", Temps_estime = DateTime.Today, CbCreateur = "Abla", CbModificateur = DateTime.Today };
            //_IObjectifsService.Save(lNewObjectifs);

            //Add Paiement
            //Paiement lNewPaiement = new Paiement() { CbCreateur = "Wejdene", CbModificateur = DateTime.Today, Employee = "Kaies", Salaire = 4700, Prime = 300, Coefficient = '4', Id = '5' };
            //_IPaiementService.Save(lNewPaiement);

            //Add Pointage

            //Pointage lNewPointage = new Pointage() { CbCreateur = "Wejdene", CbModificateur = DateTime.Today, Employee = "Asma", Entree = DateTime.Today, Sortie = DateTime.Today, EntreeM = DateTime.Today, SortieM = DateTime.Today, Id = '4' };
            //_IPointageService.Save(lNewPointage);

            //Add Role

            //Role lNewRole = new Role() { CbCreateur = "Wejedene", CbModificateur = DateTime.Today, role = "Scrum Master", Id = '3' };
            //_IRoleService.Save(lNewRole);

            //Add type
            //TypeConges lNewTypeConges = new TypeConges() { CbCreateur = "Wejedene", CbModificateur = DateTime.Today, Intitule = "mokhtar" };
            //_ITypeCongesService.Save(lNewTypeConges);


            ////Add Tache

            //Taches lNewTache = new Taches() { CbCreateur = "Mohamed", CbModificateur = DateTime.Today, Duree = DateTime.Today, Module = "Dev",Type="dev",Projet="dev",Name="dev",Id='3',Temps_estime= DateTime.Today};
            //_ITacheService.Save(lNewTache);

            /*UPDATE*/

            //update Accessoires
            //Accessoires lAccessoiresToUpdate = _IAccessoireService.GetByName("Mokhtar").FirstOrDefault();
            //lAccessoiresToUpdate.Employee = "Mokhtar Chouchene";
            //_IAccessoireService.Update(lAccessoiresToUpdate);

            //Update Attachment

            //Attachements lAttachementToUpdate = _IAttachmentService.GetByName("Sarra").FirstOrDefault();
            //lAttachementToUpdate.Employee = "Chams";
            //_IAttachmentService.Update(lAttachementToUpdate);

            // Update Conges
            //Conges lCongesToUpdate = _ICongesService.GetByName("wejdene").FirstOrDefault();
            //lCongesToUpdate.Employee = "Abla";
            //_ICongesService.Update(lCongesToUpdate);

            //Update Groupe
            //Groupe lGroupeToUpdate = _IGroupeService.GetByName("Groupec").FirstOrDefault();
            //lGroupeToUpdate.Name = "GroupeD";
            //_IGroupeService.Update(lGroupeToUpdate);

            //Update Employee
            //Employee lEmployeeToUPdate = _IEmployeeService.GetByName("Mokhtar Chouchene").FirstOrDefault();
            //lEmployeeToUPdate.Name = "Mohamed Mokhtar Chouchene";
            //_IEmployeeService.Update(lEmployeeToUPdate);

            //Update Log 
            //Log lLogToUPdate = _ILogService.GetByName("Ajouter un objectifs").FirstOrDefault();
            //lLogToUPdate.Message = "Modifier un objectif";
            //_ILogService.Update(lLogToUPdate);

            //Update Objectifs

            //Objectifs lObjectifsToUpdate = _IObjectifsService.GetByName("Application Mobile").FirstOrDefault();
            //lObjectifsToUpdate.Projet = "projet developement web";
            //_IObjectifsService.Update(lObjectifsToUpdate);

            //Update Paiement

            //Paiement lPaiementToUpdate = _IPaiementService.GetByName("Khawla hmila").FirstOrDefault();
            //lPaiementToUpdate.Employee = "Ahlem";
            //_IPaiementService.Update(lPaiementToUpdate);

            //Update Pointage

            //Pointage lPointageToUpdate = _IPointageService.GetByName("Mohamed").FirstOrDefault();
            //lPointageToUpdate.Employee="Mohamed Zitouni";
            //_IPointageService.Update(lPointageToUpdate);

            //Update Role

            //Role lRoleToUpdate=_IRoleService.GetByName("ajouter un employee").FirstOrDefault();
            //lRoleToUpdate.role = "exporter  un employee";
            //_IRoleService.Update(lRoleToUpdate);

            //Update 
            //Taches LTacheToUpdate=_ITacheService.GetByName("dev").FirstOrDefault();
            //LTacheToUpdate.Name = "integrer les nouveaux fonctionnalites";
            //_ITacheService.Update(LTacheToUpdate);


            /*DELETE*/

            //Delete Tache
            //Taches LTacheToUpdate = _ITacheService.GetByName("integrer les nouveaux fonctinnalites").FirstOrDefault();
            //_ITacheService.Delete(LTacheToUpdate);

            ////Delete Role 

            //Role lRoleToUpdate = _IRoleService.GetByName("exporter  un employee").FirstOrDefault();
            //_IRoleService.Delete(lRoleToUpdate);

            ////Pointage

            //Pointage lPointageToUpdate = _IPointageService.GetByName("Mohamed Zitouni").FirstOrDefault();
            //_IPointageService.Delete(lPointageToUpdate);

            ////Delete Paiement 

            //Paiement lPaiementToUpdate = _IPaiementService.GetByName("Ahlem").FirstOrDefault();
            //_IPaiementService.Delete(lPaiementToUpdate);

            //Delete Objectis
            //Objectifs lObjectifsToUpdate = _IObjectifsService.GetByName("projet developement web").FirstOrDefault();
            //_IObjectifsService.Delete(lObjectifsToUpdate);

            //Delete Log

            //Log lLogToUPdate = _ILogService.GetByName("Modifier  un objectif").FirstOrDefault();
            //_ILogService.Delete(lLogToUPdate);

            //Delete Employee

            //Employee lEmployeeToUPdate = _IEmployeeService.GetByName("Mokhtar Chouchene").FirstOrDefault();
            //_IEmployeeService.Delete(lEmployeeToUPdate);

            //Delete groupe
            //Groupe lGroupeToUpdate = _IGroupeService.GetByName("GroupeD").FirstOrDefault();
            //_IGroupeService.Delete(lGroupeToUpdate);


            //Delete Conges
            //Conges lCongesToUpdate = _ICongesService.GetByName("Abla").FirstOrDefault();
            //_ICongesService.Delete(lCongesToUpdate);


            //Delete attach
            //Attachements lAttachementToUpdate = _IAttachmentService.GetByName("chams").FirstOrDefault();
            //_IAttachmentService.Delete(lAttachementToUpdate);

            //Delete Acc

            //Accessoires lAccessoiresToUpdate = _IAccessoireService.GetByName("Mokhtar Chouchene").FirstOrDefault();
            //_IAccessoireService.Delete(lAccessoiresToUpdate);



            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}