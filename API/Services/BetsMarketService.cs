namespace API.Services
{
    /// <summary>
    /// Основной сервис для ведения АПИ маркета ставок.
    /// </summary>
    public class BetsMarketService : BackgroundService
    {
        /// <summary>>
        /// Создает новый экземпляр <see cref="BetsMarketService"/>.
        /// </summary>
        /// <param name="processor">
        /// Обработчик ставок.
        /// </param>
        /// <param name="logger">
        /// Логгер.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// Если один из входных параметров был равен <see langword="null"/>.
        /// </exception>
        public BetsMarketService(
            ILogger<BetsMarketService> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));

            _logger.LogInformation("Bets market service is created succesfully");
        }

        /// <inheritdoc/>
        protected override Task ExecuteAsync(CancellationToken stoppingToken)
            => Task.Run(() => Task.CompletedTask, stoppingToken);

        private readonly ILogger<BetsMarketService> _logger;
    }
}
