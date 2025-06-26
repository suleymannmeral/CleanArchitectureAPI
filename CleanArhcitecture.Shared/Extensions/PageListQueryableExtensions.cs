using CleanArhcitecture.Shared.Models;
using Microsoft.EntityFrameworkCore;


namespace CleanArhcitecture.Shared.Extensions
{

    public static class PagesListQueryableExtensions
    {
        public static async Task<PaginationResult<T>> ToPagedListAsync<T>(
            this IQueryable<T> source,
            int pageNumber,
            int pageSize,
            CancellationToken cancellationToken = default)
            where T : class
        {
            var count = await source.CountAsync(cancellationToken);
            if (count > 0)
            {
                var items = await source
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .AsNoTracking()
                    .ToListAsync(cancellationToken);

                return new(items, pageNumber, pageSize, count);
            }
            return new(null, 0, 0, 0);
        }
    }
}
