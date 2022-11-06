using System.Web;
using IranAcademiaChatBotServer.Agents.Academia.NeoLms.Models;
using Microsoft.AspNetCore.WebUtilities;
using NeoLms.Api.DotNet.Models;
using Newtonsoft.Json;

namespace IranAcademiaChatBotServer.Agents.Academia.NeoLms;

public class NeoLmsClient
{
    private string _host;
    private string _key;

    public NeoLmsClient(string host, string apiKey)
    {
        _host = host;
        _key = apiKey;
    }

    public Task<VersionResponse> GetVersion()
    {
        var result = Execute<VersionResponse>("get_version");
        return result;
    }

    public Task<AuthenticationResponse> IsAuthenticated(string userid, string password)
    {
        var queryParams = new List<KeyValuePair<string, string>>();
        queryParams.Add(new KeyValuePair<string, string>("userid", userid));
        queryParams.Add(new KeyValuePair<string, string>("password", password));

        var result = Execute<AuthenticationResponse>("is_authenticated", queryParams);
        return result;
    }

    public Task<List<User>> GetAllUsers(int page)
    {
        var queryParams = new List<KeyValuePair<string, string>>();
        queryParams.Add(new KeyValuePair<string, string>("page", page.ToString()));

        var result = Execute<List<User>>("get_all_users", queryParams);
        return result;
    }

    public Task<List<User>> GetUsersByIds(int[] ids)
    {
        var queryParams = new List<KeyValuePair<string, string>>();
        foreach (var id in ids)
        {
            queryParams.Add(new KeyValuePair<string, string>("user_ids[]", id.ToString()));
        }

        var result = Execute<List<User>>("get_users_with_ids", queryParams);
        return result;
    }

    public Task<List<EducationClass>> GetAllClasses(int page)
    {
        var queryParams = new List<KeyValuePair<string, string>>();
        queryParams.Add(new KeyValuePair<string, string>("page", page.ToString()));

        var result = Execute<List<EducationClass>>("get_all_classes", queryParams);
        return result;
    }

    public Task<List<EducationClass>> GetClassesByIds(int[] ids)
    {
        var queryParams = new List<KeyValuePair<string, string>>();
        foreach (var id in ids)
        {
            queryParams.Add(new KeyValuePair<string, string>("class_ids[]", id.ToString()));
        }

        var result = Execute<List<EducationClass>>("get_classes_with_ids", queryParams);
        return result;
    }

    public Task<List<EducationClass>> GetClassesEnrolledBy(int userId)
    {
        var queryParams = new List<KeyValuePair<string, string>>();
        queryParams.Add(new KeyValuePair<string, string>("user_id", userId.ToString()));

        return Execute<List<EducationClass>>("get_classes_enrolled_by", queryParams);
    }

    public Task<List<EducationClass>> GetClassesForOrganization(int organizationId, int page)
    {
        var queryParams = new List<KeyValuePair<string, string>>();

        queryParams.Add(new KeyValuePair<string, string>("organization_id", organizationId.ToString()));
        queryParams.Add(new KeyValuePair<string, string>("page", page.ToString()));

        return Execute<List<EducationClass>>("get_classes_for_organization", queryParams);
    }

    public Task<List<Teacher>> GetTeachersForClass(int classId)
    {
        var queryParams = new List<KeyValuePair<string, string>>();
        queryParams.Add(new KeyValuePair<string, string>("class_id", classId.ToString()));

        return Execute<List<Teacher>>("get_teachers_for_class", queryParams);
    }

    public Task<List<Student>> GetStudentsForClass(int classId)
    {
        var queryParams = new List<KeyValuePair<string, string>>();
        queryParams.Add(new KeyValuePair<string, string>("class_id", classId.ToString()));

        return Execute<List<Student>>("get_students_for_class", queryParams);
    }

    public Task<UserClassesStatus> GetUserSatus(int userId)
    {
        var queryParams = new List<KeyValuePair<string, string>>();
        queryParams.Add(new KeyValuePair<string, string>("user_id", userId.ToString()));

        return Execute<UserClassesStatus>("get_status_of_classes", queryParams);
    }

    public Task<List<Group>> GetAllGroups(int page)
    {
        var queryParams = new List<KeyValuePair<string, string>>();

        queryParams.Add(new KeyValuePair<string, string>("page", page.ToString()));
        return Execute<List<Group>>("get_all_groups", queryParams);
    }

    public Task<List<Group>> GetGroupsWithMember(int userId)
    {
        var queryParams = new List<KeyValuePair<string, string>>();
        queryParams.Add(new KeyValuePair<string, string>("user_id", userId.ToString()));

        return Execute<List<Group>>("get_groups_with_member", queryParams);
    }

    public Task<ResourcesResult> GetResources(Dictionary<string, object> queryParamsDict, int page)
    {
        var queryParams = new List<KeyValuePair<string, string>>();
        foreach (var queryParam in queryParamsDict)
        {
            queryParams.Add(new KeyValuePair<string, string>(queryParam.Key, queryParam.Value.ToString()));
        }
        queryParams.Add(new ("page", page.ToString()));

        return Execute<ResourcesResult>("get_resources", queryParams);
    }

    private async Task<T> Execute<T>(string path, List<KeyValuePair<string, string>> queryParams = null)
    {
        string rawResponse = await this.Get(path, queryParams);
        return JsonConvert.DeserializeObject<T>(rawResponse);
    }

    private async Task<string> Get(string path, List<KeyValuePair<string, string>> queryParams)
    {
        var url = $"{_host}/api/{path}";
        var httpClient = new HttpClient();

        url = QueryHelpers.AddQueryString(url, "api_key", _key);

        var query = HttpUtility.ParseQueryString(string.Empty);
        query["api_key"] = _key;

        if (queryParams != null)
        {
            foreach (var param in queryParams)
            {
                url = QueryHelpers.AddQueryString(url, param.Key, param.Value);
            }
        }

        try
        {
            return await httpClient.GetStringAsync(url);
        }
        catch (Exception ex)
        {
            throw new ApiException("Cypherlearning Exception", ex);
        }
    }
}
