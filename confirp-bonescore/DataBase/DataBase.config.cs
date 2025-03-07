using static BonesCore.Models.GroupByModel;

namespace societario_api.Base;

public static class BaseScripts
{
    public static string JSON_START = $"{CodesEnum.BR}DECLARE @JSON nvarchar(max) {CodesEnum.BR}SET @JSON = (";

    public static string JSON_END = $"{CodesEnum.BR} FOR JSON PATH) SELECT @JSON AS 'result'";
}
