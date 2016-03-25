using System.Collections.Generic;
using System.Linq;
using Nancy;
using NzbDrone.Api.Extensions;
using NzbDrone.Core.Tv;

namespace NzbDrone.Api.Series
{
    public class SeriesEditorModule : NzbDroneApiModule
    {
        private readonly ISeriesService _seriesService;

        public SeriesEditorModule(ISeriesService seriesService)
            : base("/series/editor")
        {
            _seriesService = seriesService;
            Put["/"] = series => SaveAll();
        }

        private Response SaveAll()
        {
            //Read from request
            var resources = Request.Body.FromJson<List<SeriesResource>>();

#warning TODO: Shouldn't we somehow handle which properties can be set instead of injecting all of it?
            var series = resources.Select(SeriesResourceMapper.ToModel).ToList();

            return _seriesService.UpdateSeries(series)
                                 .ToResource()
                                 .AsResponse(HttpStatusCode.Accepted);
        }
    }
}
