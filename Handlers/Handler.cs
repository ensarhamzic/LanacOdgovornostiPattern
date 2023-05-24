using FasadaDomaci.Repositories;
using LanacOdgovornostiPattern.Repositories;
using LanacOdgovornostiPattern.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanacOdgovornostiPattern.Handlers
{
    public abstract class Handler
    {
        protected Handler nextHandler;
        protected KursRepository KursRepository { get; set; }
        protected NastavnikRepository NastavnikRepository { get; set; }
        protected MaterijalRepository MaterijalRepository { get; set; }

        public Handler()
        {
            NastavnikRepository = new NastavnikRepository();
            KursRepository = new KursRepository();
            MaterijalRepository = new MaterijalRepository();
        }

        public void SetNextHandler(Handler handler)
        {
            nextHandler = handler;
        }

        public virtual void HandleRequest(NoviMaterijalRequest request)
        {
            nextHandler?.HandleRequest(request);
        }
    }
}
