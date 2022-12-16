using System.Collections.Generic;

namespace RocketChat.Queries
{

    public class BasicQuery
    {
        ///<summary>
        ///房间Id
        ///</summary>
        public string RoomId { get; set; }
        ///<summary>
        ///房间的名字
        ///</summary>
        public string RoomName { get; set; }
        ///<summary>
        ///在查询中要“跳过”的项的数量，是基于0的，所以它从0开始是第一个项。
        ///</summary>
        public int? Offset { get; set; }
        ///<summary>
        ///要在查询中“获取”的项的数量是基于1的，所以为了只获取一个，你需要传入1个。如果你想要得到所有的记录，那么传入0，但是只有在设置允许的情况下(见下面)才会生效。
        ///</summary>
        public int? Count { get; set; }
        ///<summary>
        ///指定返回结果的顺序。Sort哈希使用属性名作为key，值为1代表asc， -1代表desc。
        ///</summary>
        public Sort Sort { get; set; }

        public BasicQuery()
        {
            RoomId = null;
            RoomName = null;
            Offset = null;
            Count = null;
            Sort = null;
        }

        public string ToQueryString()
        {
            var queryParams = GetByIdOrName(RoomId, RoomName);
            TryAddField(Offset, "offset", queryParams);
            TryAddField(Count, "count", queryParams);
            TryAddField(Sort, "sort", queryParams);
            return QueryHelper.DicToQuerystring(queryParams);
        }

        protected void TryAddField(int? field, string name, Dictionary<string, string> queryParams)
        {
            if (field.HasValue)
                queryParams.Add(name, field.Value.ToString());
        }

        protected void TryAddField(string field, string name, Dictionary<string, string> queryParams)
        {
            if (!string.IsNullOrEmpty(field))
                queryParams.Add(name, field.ToString());
        }

        protected void TryAddField(Sort field, string name, Dictionary<string, string> queryParams)
        {
            if (field != null)
                queryParams.Add(name, field.ToQueryString());
        }

        protected Dictionary<string, string> GetByIdOrName(string roomId, string roomName)
        {
            var queryParams = new Dictionary<string, string>();
            if (!string.IsNullOrEmpty(roomId))
                queryParams.Add("roomId", roomId);
            else if (!string.IsNullOrEmpty(roomName) && !queryParams.ContainsKey("roomId"))
                queryParams.Add("roomName", roomName);
            return queryParams;
        }
    }

    public class FullQuery : BasicQuery
    {

        ///<summary>
        ///https://localhost: 3000 / api / v1 / users.list ?查询= {" name ": {" $ regex ": " g "}}
        ///</summary>
        public string Query { get; set; }
        ///<summary>
        ///http://localhost:3000/api/v1/users.list?fields={"username": 1}
        ///</summary>
        public string Fields { get; set; }

        public FullQuery() : base()
        {
            Query = null;
            Fields = null;
        }

        public new string ToQueryString()
        {
            var queryParams = GetByIdOrName(RoomId, RoomName);
            TryAddField(Offset, "offset", queryParams);
            TryAddField(Count, "count", queryParams);
            TryAddField(Sort, "sort", queryParams);
            TryAddField(Query, "query", queryParams);
            TryAddField(Fields, "fields", queryParams);
            return QueryHelper.DicToQuerystring(queryParams);
        }
    }
}
