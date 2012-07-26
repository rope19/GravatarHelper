﻿namespace GravatarHelper.Tests
{
    /// <summary>
    /// Base class for GravatarHelper unit tests. Sets up the GetHttpContext Func to work without a HttpContext.
    /// </summary>
    public abstract class BaseGravatarTests
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseGravatarTests"/> class.
        /// </summary>
        public BaseGravatarTests()
        {
            this.HttpRequest = new TestHttpRequest();
            GravatarHelper.GetHttpContext = () => new TestHttpContext(this.HttpRequest);
        }

        /// <summary>
        /// Gets or sets our testing HttpRequest; allowing us to switch between secure / non-secure connection. 
        /// </summary>
        /// <value>
        /// The HTTP request.
        /// </value>
        internal TestHttpRequest HttpRequest { get; set; }
    }
}
