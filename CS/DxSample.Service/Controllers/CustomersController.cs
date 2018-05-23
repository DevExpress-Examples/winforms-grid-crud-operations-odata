using DxSample.Service.Models;
using System.Linq;
using System.Web.Http;
using System.Threading.Tasks;
using System.Net;
using System.Web.OData;

namespace DxSample.Service.Controllers {
    public class CustomersController :ODataController {
        private bool CustomerExists(int key) {
            return DataContext.Customers.Any(c => c.ID == key);
        }

        [EnableQuery]
        public IQueryable<Customer> Get() {
            return DataContext.Customers;
        }

        [EnableQuery]
        public SingleResult<Customer> Get([FromODataUri] int key) {
            IQueryable<Customer> result = DataContext.Customers.Where(c => c.ID == key);
            return SingleResult.Create(result);
        }

        public async Task<IHttpActionResult> Post(Customer customer) {
            if (!this.ModelState.IsValid) return this.BadRequest(this.ModelState);
            customer = await DataContext.AddCustomer(customer.Name);
            return this.Created(customer);
        }

        public async Task<IHttpActionResult> Patch([FromODataUri] int key, Delta<Customer> customer) {
            if (!this.ModelState.IsValid) return this.BadRequest(this.ModelState);
            Customer entity = await DataContext.FindCustomerAsync(key);
            if (entity == null) return this.NotFound();
            customer.Patch(entity);
            return this.Updated(entity);
        }

        public async Task<IHttpActionResult> Put([FromODataUri] int key, Customer update) {
            if (!this.ModelState.IsValid) return this.BadRequest(this.ModelState);
            if (key != update.ID) return this.BadRequest();
            await DataContext.UpdateCustomer(update);
            return this.Updated(update);
        }

        public async Task<IHttpActionResult> Delete([FromODataUri] int key) {
            Customer customer = await DataContext.FindCustomerAsync(key);
            if (customer == null) return this.NotFound();
            await DataContext.RemoveCustomer(customer);
            return this.StatusCode(HttpStatusCode.NoContent);
        }
    }
}