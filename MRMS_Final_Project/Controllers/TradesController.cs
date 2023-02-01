using Microsoft.AspNetCore.Mvc;
using MRMS.DAL;
using MRMS.Model.DemandSection;

namespace MRMS_Final_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TradesController : ControllerBase
    {
        private IGlobalRepository _globalRepo;       
        private IGenericRepository<Trade> _tradeRepo;

       
        public TradesController(IGlobalRepository globalRepo)
        {
            this._globalRepo = globalRepo;           
            this._tradeRepo = _globalRepo.TradeRepository;
           

        }
        //Get Data
        [HttpGet]
        public IEnumerable<Trade> GetTrades()
        {
            return _tradeRepo.GetAll();
        }
        [HttpPost]
        public IActionResult PostTrade(Trade trade)
        {
            _tradeRepo.Insert(trade);
            _globalRepo.Save();
            return Ok(trade);

        }

        [HttpPut]
        public IActionResult UpdateTrade(Trade trade)
        {
            if (trade.TradeId == 0)
            {
                return NoContent();
            }
            _tradeRepo.Update(trade);
            _globalRepo.Save();
            return Ok(trade);

        }
        [HttpDelete("{id}")]
        public IActionResult DeleteTrade(int id)
        {
            Trade trade = _tradeRepo.Get(id);
            if (trade == null)
            {
                return NotFound();
            }
            _tradeRepo.Delete(trade);
            _globalRepo.Save();
            return Ok(trade);
        }
    }
}
