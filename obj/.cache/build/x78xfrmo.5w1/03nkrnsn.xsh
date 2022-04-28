﻿<!DOCTYPE html>
<!--[if IE]><![endif]-->
<html>
  
  <head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
    <title>Class DropboxException
   </title>
    <meta name="viewport" content="width=device-width">
    <meta name="title" content="Class DropboxException
   ">
    <meta name="generator" content="docfx 2.58.4.0">
    
    <link rel="shortcut icon" href="../../../favicon.ico">
    <link rel="stylesheet" href="../../../styles/docfx.vendor.css">
    <link rel="stylesheet" href="../../../styles/docfx.css">
    <link rel="stylesheet" href="../../../styles/main.css">
    <meta property="docfx:navrel" content="../../../toc.html">
    <meta property="docfx:tocrel" content="toc.html">
    
    
    
  </head>
  <body data-spy="scroll" data-target="#affix" data-offset="120">
    <div id="wrapper">
      <header>
        
        <nav id="autocollapse" class="navbar navbar-inverse ng-scope" role="navigation">
          <div class="container">
            <div class="navbar-header">
              <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#navbar">
                <span class="sr-only">Toggle navigation</span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
              </button>
              
              <a class="navbar-brand" href="../../../index.html">
                <img id="logo" class="svg" src="../../../logo.svg" alt="">
              </a>
            </div>
            <div class="collapse navbar-collapse" id="navbar">
              <form class="navbar-form navbar-right" role="search" id="search">
                <div class="form-group">
                  <input type="text" class="form-control" id="search-query" placeholder="Search" autocomplete="off">
                </div>
              </form>
            </div>
          </div>
        </nav>
        
        <div class="subnav navbar navbar-default">
          <div class="container hide-when-search" id="breadcrumb">
            <ul class="breadcrumb">
              <li></li>
            </ul>
          </div>
        </div>
      </header>
      <div role="main" class="container body-content hide-when-search">
        
        <div class="sidenav hide-when-search">
          <a class="btn toc-toggle collapse" data-toggle="collapse" href="#sidetoggle" aria-expanded="false" aria-controls="sidetoggle">Show / Hide Table of Contents</a>
          <div class="sidetoggle collapse" id="sidetoggle">
            <div id="sidetoc"></div>
          </div>
        </div>
        <div class="article row grid-right">
          <div class="col-md-10">
            <article class="content wrap" id="_content" data-uid="Dropbox.Api.DropboxException">
  
  
  <h1 id="Dropbox_Api_DropboxException" data-uid="Dropbox.Api.DropboxException" class="text-break">Class DropboxException
  </h1>
  <div class="markdown level0 summary"><p>Base class for all exceptions from Dropbox service.</p>
</div>
  <div class="markdown level0 conceptual"></div>
  <div class="inheritance">
    <h5>Inheritance</h5>
    <div class="level0"><span class="xref">System.Object</span></div>
    <div class="level1"><span class="xref">System.Exception</span></div>
    <div class="level2"><span class="xref">DropboxException</span></div>
      <div class="level3"><a class="xref" href="Dropbox.Api.HttpException.html">HttpException</a></div>
      <div class="level3"><a class="xref" href="Dropbox.Api.StructuredException-1.html">StructuredException&lt;TError&gt;</a></div>
  </div>
  <div classs="implements">
    <h5>Implements</h5>
    <div><span class="xref">System.Runtime.InteropServices._Exception</span></div>
    <div><span class="xref">System.Runtime.Serialization.ISerializable</span></div>
  </div>
  <div class="inheritedMembers">
    <h5>Inherited Members</h5>
    <div>
      <span class="xref">System.Exception.GetBaseException()</span>
    </div>
    <div>
      <span class="xref">System.Exception.GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)</span>
    </div>
    <div>
      <span class="xref">System.Exception.GetType()</span>
    </div>
    <div>
      <span class="xref">System.Exception.Data</span>
    </div>
    <div>
      <span class="xref">System.Exception.HelpLink</span>
    </div>
    <div>
      <span class="xref">System.Exception.HResult</span>
    </div>
    <div>
      <span class="xref">System.Exception.InnerException</span>
    </div>
    <div>
      <span class="xref">System.Exception.Message</span>
    </div>
    <div>
      <span class="xref">System.Exception.Source</span>
    </div>
    <div>
      <span class="xref">System.Exception.StackTrace</span>
    </div>
    <div>
      <span class="xref">System.Exception.TargetSite</span>
    </div>
    <div>
      <span class="xref">System.Exception.SerializeObjectState</span>
    </div>
    <div>
      <span class="xref">System.Object.Equals(System.Object)</span>
    </div>
    <div>
      <span class="xref">System.Object.Equals(System.Object, System.Object)</span>
    </div>
    <div>
      <span class="xref">System.Object.GetHashCode()</span>
    </div>
    <div>
      <span class="xref">System.Object.MemberwiseClone()</span>
    </div>
    <div>
      <span class="xref">System.Object.ReferenceEquals(System.Object, System.Object)</span>
    </div>
  </div>
  <h6><strong>Namespace</strong>: <a class="xref" href="Dropbox.Api.html">Dropbox.Api</a></h6>
  <h6><strong>Assembly</strong>: Dropbox.Api.dll</h6>
  <h5 id="Dropbox_Api_DropboxException_syntax">Syntax</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public class DropboxException : Exception, _Exception, ISerializable</code></pre>
  </div>
  <h3 id="methods">Methods
  </h3>
  <span class="small pull-right mobile-hide">
    <span class="divider">|</span>
    <a href="https://github.com/dropbox/dropbox-sdk-dotnet/new/doc_fx_integration/apiSpec/new?filename=Dropbox_Api_DropboxException_ToString.md&amp;value=---%0Auid%3A%20Dropbox.Api.DropboxException.ToString%0Asummary%3A%20'*You%20can%20override%20summary%20for%20the%20API%20here%20using%20*MARKDOWN*%20syntax'%0A---%0A%0A*Please%20type%20below%20more%20information%20about%20this%20API%3A*%0A%0A">Improve this Doc</a>
  </span>
  <span class="small pull-right mobile-hide">
    <a href="https://github.com/dropbox/dropbox-sdk-dotnet/blob/doc_fx_integration/dropbox-sdk-dotnet/Dropbox.Api/DropboxException.cs/#L39">View Source</a>
  </span>
  <a id="Dropbox_Api_DropboxException_ToString_" data-uid="Dropbox.Api.DropboxException.ToString*"></a>
  <h4 id="Dropbox_Api_DropboxException_ToString" data-uid="Dropbox.Api.DropboxException.ToString">ToString()</h4>
  <div class="markdown level1 summary"><p>The ToString().</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="decalaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public override string ToString()</code></pre>
  </div>
  <h5 class="returns">Returns</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">System.String</span></td>
        <td><p>A string that represents the current <a class="xref" href="Dropbox.Api.DropboxException.html">DropboxException</a>.</p>
</td>
      </tr>
    </tbody>
  </table>
  <h5 class="overrides">Overrides</h5>
  <div><span class="xref">System.Exception.ToString()</span></div>
  <h3 id="implements">Implements</h3>
  <div>
      <span class="xref">System.Runtime.InteropServices._Exception</span>
  </div>
  <div>
      <span class="xref">System.Runtime.Serialization.ISerializable</span>
  </div>
</article>
          </div>
          
          <div class="hidden-sm col-md-2" role="complementary">
            <div class="sideaffix">
              <div class="contribution">
                <ul class="nav">
                  <li>
                    <a href="https://github.com/dropbox/dropbox-sdk-dotnet/new/doc_fx_integration/apiSpec/new?filename=Dropbox_Api_DropboxException.md&amp;value=---%0Auid%3A%20Dropbox.Api.DropboxException%0Asummary%3A%20'*You%20can%20override%20summary%20for%20the%20API%20here%20using%20*MARKDOWN*%20syntax'%0A---%0A%0A*Please%20type%20below%20more%20information%20about%20this%20API%3A*%0A%0A" class="contribution-link">Improve this Doc</a>
                  </li>
                  <li>
                    <a href="https://github.com/dropbox/dropbox-sdk-dotnet/blob/doc_fx_integration/dropbox-sdk-dotnet/Dropbox.Api/DropboxException.cs/#L16" class="contribution-link">View Source</a>
                  </li>
                </ul>
              </div>
              <nav class="bs-docs-sidebar hidden-print hidden-xs hidden-sm affix" id="affix">
                <h5>In This Article</h5>
                <div></div>
              </nav>
            </div>
          </div>
        </div>
      </div>
      
      <footer>
        <div class="grad-bottom"></div>
        <div class="footer">
          <div class="container">
            <span class="pull-right">
              <a href="#top">Back to top</a>
            </span>
            
            <span>Generated by <strong>DocFX</strong></span>
          </div>
        </div>
      </footer>
    </div>
    
    <script type="text/javascript" src="../../../styles/docfx.vendor.js"></script>
    <script type="text/javascript" src="../../../styles/docfx.js"></script>
    <script type="text/javascript" src="../../../styles/main.js"></script>
  </body>
</html>
