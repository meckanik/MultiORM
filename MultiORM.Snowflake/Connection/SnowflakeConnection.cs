using System.Collections.ObjectModel;

namespace MultiORM.Snowflake.Connection;

public class SnowflakeConnection
{
    private const string secureProtocol = "https";
    private const string securePort = "443";

    private readonly string _account;
    private readonly string _user;
    private readonly string _password;
    private readonly string _warehouse;
    private readonly string _database;
    private readonly string _schema;
    private readonly string _protocol;
    private readonly string _port;
    private readonly string? _accountIdentifier;
    private readonly ReadOnlyCollection<string>? _connectionParams;
    private readonly int? _responseTimeout;
    private readonly bool? _outOfBandTelemetry;
    private readonly bool? _sessionKeepAlive;
    private readonly int? _keepAliveHeartbeat;

    /// <summary>
    ///     Initializes a new instance of the <see cref="SnowflakeConnection'"/> class.
    /// </summary>
    /// <param name="account">The Snowflake account value.</param>
    /// <param name="user">The Snowflake user value.</param>
    /// <param name="password">The Snowflake password value.</param>
    /// <param name="warehouse">The Snowflake warehouse value.</param>
    /// <param name="database">The Snowflake database value.</param>
    /// <param name="schema">The Snowflake schema value.</param>
    /// <param name="protocol">The Snowflake protocol value.</param>
    /// <param name="port">The Snowflake port value.</param>
    /// <param name="accountIdentifier">The Snowflake accountIdentifier value.</param>
    /// <param name="connectionParams">The Snowflake connectionParams value.</param>
    /// <param name="responseTimeout">The Snowflake responseTimeout value.</param>
    /// <param name="outOfBandTelemetry">The Snowflake outOfBandTelemetry value.</param>
    /// <param name="sessionKeepAlive">The Snowflake sessionKeepAlive value.</param>
    /// <param name="keepAliveHeartbeat">The Snowflake keepAliveHeartbeat value.</param>
    public SnowflakeConnection(
        string account,
        string user,
        string password,
        string warehouse,
        string database,
        string schema,
        string protocol = secureProtocol,
        string port = securePort,
        string? accountIdentifier = null,
        ReadOnlyCollection<string>? connectionParams = null,
        int? responseTimeout = null,
        bool? outOfBandTelemetry = null,
        bool? sessionKeepAlive = null,
        int? keepAliveHeartbeat = null
        ) 
    {
        _account = account;
        _user = user;
        _password = password;
        _warehouse = warehouse;
        _database = database;
        _schema = schema;
        _protocol = protocol;
        _port = port;
        _accountIdentifier = accountIdentifier;
        _connectionParams = connectionParams;
        _responseTimeout = responseTimeout;
        _outOfBandTelemetry = outOfBandTelemetry;
        _sessionKeepAlive = sessionKeepAlive;
        _keepAliveHeartbeat = keepAliveHeartbeat;
    }

    /// <summary>
    ///     Gets the Account value.
    /// </summary>
    public string Account => _account;

    /// <summary>
    ///     Gets the User value.
    /// </summary>
    public string User => _user;

    /// <summary>
    ///     Gets the Password value.
    /// </summary>
    public string Password => _password;

    /// <summary>
    ///     Gets the Warehouse value.
    /// </summary>
    public string Warehouse => _warehouse;

    /// <summary>
    ///     Gets the Database value.
    /// </summary>
    public string Database => _database;

    /// <summary>
    ///     Gets the Schema value.
    /// </summary>
    public string Schema => _schema;

    /// <summary>
    ///     Gets the Protocol value.
    /// </summary>
    public string Protocol => _protocol;

    /// <summary>
    ///     Gets the Port value.
    /// </summary>
    public string Port => _port;

    /// <summary>
    ///     Gets the AccountIdentifier value.
    /// </summary>
    public string? AccountIdentifier => _accountIdentifier;

    /// <summary>
    ///     Gets the ConnectionParams value.
    /// </summary>
    public ReadOnlyCollection<string>? ConnectionParams => _connectionParams;

    /// <summary>
    ///     Gets the ResponseTimeout value.
    /// </summary>
    public int? ResponseTimeout => _responseTimeout;

    /// <summary>
    ///     Gets the OutOfBandTelemetry value.
    /// </summary>
    public bool? OutOfBandTelemetry => _outOfBandTelemetry;

    /// <summary>
    ///     Gets the SessionKeepAlive value.
    /// </summary>
    public bool? SessionKeepAlive => _sessionKeepAlive;

    /// <summary>
    ///     Gets the KeepAliveHeartbeat value.
    /// </summary>
    public int? v => _keepAliveHeartbeat;
}
