using DxSample.Service.Models;
using System.Linq;
using System.Web.Http;
using System.Threading.Tasks;
using System.Net;
using System.Web.OData;

namespace DxSample.Service.Controllers {
    public class OrdersController : ODataController {
        private bool OrderExists(int key) {
            return DataContext.Orders.Any(c => c.ID == key);
        }

        [EnableQuery]
        public IQueryable<Order> Get() {
            return DataContext.Orders;
        }

        [EnableQuery]
        public SingleResult<Order> Get([FromODataUri] int key) {
            IQueryable<Order> result = DataContext.Orders.Where(c => c.ID == key);
            return SingleResult.Create(result);
        }

        public async Task<IHttpActionResult> Post(Order order) {
            if (!this.ModelState.IsValid) return this.BadRequest(this.ModelState);
            order = await DataContext.AddOrder(order.Name, order.CustomerID);
            return this.Created(order);
        }

        public async Task<IHttpActionResult> Patch([FromODataUri] int key, Delta<Order> order) {
            if (!this.ModelState.IsValid) return this.BadRequest(this.ModelState);
            Order entity = await DataContext.FindOrderAsync(key);
            if (entity == null) return this.NotFound();
            order.Patch(entity);
            return this.Updated(entity);
        }

        public async Task<IHttpActionResult> Put([FromODataUri] int key, Order update) {
            if (!this.ModelState.IsValid) return this.BadRequest(this.ModelState);
            if (key != update.ID) return this.BadRequest();
            await DataContext.UpdateOrder(update);
            return this.Updated(update);
        }

        public async Task<IHttpActionResult> Delete([FromODataUri] int key) {
            Order order = await DataContext.FindOrderAsync(key);
            if (order == null) return this.NotFound();
            await DataContext.RemoveOrder(order);
            return this.StatusCode(HttpStatusCode.NoContent);
        }
    }
}