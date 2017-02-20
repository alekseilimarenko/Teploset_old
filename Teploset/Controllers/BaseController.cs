using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Teploset.EF;

namespace Teploset.Controllers
{
    public class BaseController{
        protected Entities Db { get { return _repository.Db; } }
        public TeplosetUnitOfWork _repository;

        protected readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public BaseController(TeplosetUnitOfWork repo)
        {
            _repository = repo;
        }

        public BaseController() { }
    }
}