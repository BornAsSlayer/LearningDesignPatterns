namespace Builder;

public class URLBuilder
{
    public class Builder
    {
        internal string? protocol;
        internal string? domainName;
        internal string? port;
        internal string? pathName;
        internal string? queryName;

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
    }

    public string? protocol;
    public string? domainName;
    public string? port;
    public string? pathName;
    public string? queryName;

    private URLBuilder(Builder builder)
    {
        this.protocol = builder.protocol;
        this.domainName = builder.domainName;
        this.port = builder.port;
        this.pathName = builder.pathName;
        this.queryName = builder.queryName;
    }

}
