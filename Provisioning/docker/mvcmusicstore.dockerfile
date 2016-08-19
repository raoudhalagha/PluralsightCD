from marcelv/pluralsightcourse2
RUN mkdir c:\MvcMusicstore
WORKDIR /MvcMusicStore
ADD MvcMusicstore.zip  /MvcDockerDocker/MvcMusicStore.zip
RUN powershell -executionpolicy bypass -Command "expand-archive -Path '/MvcDockerDocker/MvcMusicStore.zip' -DestinationPath 'c:\inetpub\wwwroot\'"
RUN /windows/system32/inetsrv/appcmd.exe set vdir "Default Web Site/" -physicalPath:"c:\inetpub\wwwroot\Content\d_C\demobuild\1\s\MvcMusicStore\obj\Release\Package\PackageTmp"
