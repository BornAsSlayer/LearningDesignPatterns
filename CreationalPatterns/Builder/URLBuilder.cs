namespace Builder;

public class URLBuilder
{
    public class Builder
    {
        private string? protocol;
        private string? domainName;
        private string? port;
        private string? pathName;
        private string? queryName;

        public Builder Protocol (string protocol)
        {
            this.protocol = protocol;
            return this;
        }

        public Builder DomainName (string domainName)
        {
            this.domainName = domainName;
            return this;
        }

        public Builder Port (string port)
        {
            this.port = port;
            return this;
        }

        public Builder PathName (string pathName)
        {
            this.pathName = pathName;
            return this;
        }

        public Builder QueryName (string queryName)
        {
            this.queryName = queryName;
            return this;
        }

        public URLBuilder Build()
        {
            return new URLBuilder(this);
        }

        internal string? GetProtocol() => protocol;
        internal string? GetDomainName() => domainName;
        internal string? GetPort() => port;
        internal string? GetPathName() => pathName;
        internal string? GetQueryName() => queryName;
    }

    public string? protocol;
    public string? domainName;
    public string? port;
    public string? pathName;
    public string? queryName;

    private URLBuilder(Builder builder)
    {
        this.protocol = builder.GetProtocol();
        this.domainName = builder.GetDomainName();
        this.port = builder.GetPort();
        this.pathName = builder.GetPathName();
        this.queryName = builder.GetQueryName();
    }

}
