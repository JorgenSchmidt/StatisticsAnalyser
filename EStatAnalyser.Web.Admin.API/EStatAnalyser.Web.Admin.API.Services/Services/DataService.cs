using EStatAnalyser.Web.Admin.API.Core.Entities;
using EStatAnalyser.Web.Admin.API.Core.Enums;
using EStatAnalyser.Web.Admin.API.Core.Interfaces.RepositoryInterfaces;
using EStatAnalyser.Web.Admin.API.Core.Interfaces.ServiceInterfaces;
using EStatAnalyser.Web.Admin.API.Core.Responses;
using Microsoft.Extensions.Logging;

namespace EStatAnalyser.Web.Admin.API.Services.Services
{
    public class DataService : IDataService
    {

        private readonly IDataRepository _dataRepository;
        private readonly ILogger<DataService> _logger;

        public DataService(IDataRepository dataRepository, ILogger<DataService> logger)
        {
            _dataRepository = dataRepository;
            _logger = logger;
        }

        public async Task<BaseResponse> GetAll()
        {
            try
            {
                // Обращение к репозиторию
                var Result = await _dataRepository.GetAll();
                // Проверка полученного результата
                if (Result == null)
                {
                    _logger.LogInformation("\n(INCORR) - GetAllMethod: Data was null.");
                    return new BaseResponse
                    {
                        Body = "\n(INCORR) - GetAllMethod: Data was null.",
                        Status = StatusCodes.IncorrectRequest
                    };
                }

                // Логгирование
                _logger.LogInformation("\n(OK) - GetAllMethod.");
                return new BaseResponse
                {
                    Body = Result,
                    Status = StatusCodes.OK
                };
            }
            catch (Exception ex)
            {
                _logger.LogInformation("\n(ERR) - GetAllMethod throw exception: " + ex.Message);
                return new BaseResponse
                {
                    Body = "\n(ERR) - GetAllMethod throw exception: " + ex.Message,
                    Status = StatusCodes.InternalServerError
                };
            }
        }

        public async Task<BaseResponse> GetByID(int Id)
        {
            try
            {
                var Result = _dataRepository.GetByID(Id);
                if (Result == null)
                {
                    _logger.LogInformation("\n(INCORR) - GetByID: Data was null.");
                    return new BaseResponse
                    {
                        Body = "\n(INCORR) - GetByID: Data was null.",
                        Status = StatusCodes.IncorrectRequest
                    };
                }

                _logger.LogInformation("\n(OK) - GetByID.");
                return new BaseResponse
                {
                    Body = Result,
                    Status = StatusCodes.OK
                };
            }
            catch (Exception ex)
            {
                _logger.LogInformation("\n(ERR) - GetByID throw exception: " + ex.Message);
                return new BaseResponse
                {
                    Body = "\n(ERR) - GetByID throw exception: " + ex.Message,
                    Status = StatusCodes.InternalServerError
                };
            }
        }

        public async Task<BaseResponse> AddEntity(Data data)
        {
            try
            {
                if (data == null)
                {
                    _logger.LogInformation("\n(INCORR) - AddEntity: Data was null.");
                    return new BaseResponse
                    {
                        Body = "\n(INCORR) - AddEntity: Data was null.",
                        Status = StatusCodes.IncorrectRequest
                    };
                }

                // Обращение к репозиторию
                var Result = _dataRepository.AddEntity(data);

                // Обработка результатов запроса к БД
                if (Result.Result.Status == StatusCodes.OK)
                {
                    _logger.LogInformation("\n(OK) - AddEntity.");
                    return new BaseResponse
                    {
                        Status = Result.Result.Status
                    };
                }
                else
                {
                    _logger.LogInformation("\n(ERR) - AddEntity throw exception: " + Result.Result.Message);
                    return new BaseResponse
                    {
                        Body = "\n(ERR) - AddEntity throw exception: " + Result.Result.Message,
                        Status = StatusCodes.InternalServerError
                    };
                }
            }
            catch (Exception ex)
            {
                _logger.LogInformation("\n(ERR) - AddEntity throw exception: " + ex.Message);
                return new BaseResponse
                {
                    Body = "\n(ERR) - AddEntity throw exception: " + ex.Message,
                    Status = StatusCodes.InternalServerError
                };
            }
        }

        public async Task<BaseResponse> DeleteEntity(int Id)
        {
            try
            {
                var Result = _dataRepository.DeleteEntity(Id);

                if (Result.Result.Status == StatusCodes.OK)
                {
                    _logger.LogInformation("\n(OK) - DeleteEntity.");
                    return new BaseResponse
                    {
                        Status = Result.Result.Status
                    };
                }
                else
                {
                    _logger.LogInformation("\n(ERR) - DeleteEntity throw exception: " + Result.Result.Message);
                    return new BaseResponse
                    {
                        Body = "\n(ERR) - DeleteEntity throw exception: " + Result.Result.Message,
                        Status = StatusCodes.InternalServerError
                    };
                }
            }
            catch (Exception ex)
            {
                _logger.LogInformation("\n(ERR) - DeleteEntity throw exception: " + ex.Message);
                return new BaseResponse
                {
                    Body = "\n(ERR) - DeleteEntity throw exception: " + ex.Message,
                    Status = StatusCodes.InternalServerError
                };
            }
        }

        public async Task<BaseResponse> UpdateEntity(Data data)
        {
            try
            {
                if (data == null)
                {
                    _logger.LogInformation("\n(INCORR) - UpdateEntity: Data was null.");
                    return new BaseResponse
                    {
                        Body = "\n(INCORR) - UpdateEntity: Data was null.",
                        Status = StatusCodes.IncorrectRequest
                    };
                }
                var Result = _dataRepository.UpdateEntity(data);

                if (Result.Result.Status == StatusCodes.OK)
                {
                    _logger.LogInformation("\n(OK) - UpdateEntity.");
                    return new BaseResponse
                    {
                        Status = Result.Result.Status
                    };
                }
                else
                {
                    _logger.LogInformation("\n(ERR) - UpdateEntity throw exception: " + Result.Result.Message);
                    return new BaseResponse
                    {
                        Body = "\n(ERR) - UpdateEntity throw exception: " + Result.Result.Message,
                        Status = StatusCodes.InternalServerError
                    };
                }
            }
            catch (Exception ex)
            {
                _logger.LogInformation("\n(ERR) - UpdateEntity throw exception: " + ex.Message);
                return new BaseResponse
                {
                    Body = "\n(ERR) - UpdateEntity throw exception: " + ex.Message,
                    Status = StatusCodes.InternalServerError
                };
            }
        }
    }
}