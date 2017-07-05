using ObrasFai.Infra.Persistence.DataContexts;

namespace ObrasFai.Infra.Persistence
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private ObrasFaiDataContext _context;

        public UnitOfWork(ObrasFaiDataContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_context != null)
                {
                    _context.Dispose();
                    _context = null;
                }
            }
        }
    }
}
