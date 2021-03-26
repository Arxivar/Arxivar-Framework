SET Folder=%cd%\

java -jar %Folder%swagger-codegen-cli-2.3.1.jar generate -i http://vm05-nextcorso:80/ARXivarNextWebApi/swagger/docs/data -l csharp -o %Folder%GenerazioneCodice