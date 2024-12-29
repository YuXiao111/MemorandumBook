应用层（业务层）Application
数据层Database

复制命令
copy /Y "$(TargetDir)$(ProjectName).dll" "$(SolutionDir)Note.Shell\bin\Debug\net8.0-windows7.0"
copy /Y "$(TargetDir)$(ProjectName).dll" "$(SolutionDir)Note.Shell\bin\Release\net8.0-windows7.0"
