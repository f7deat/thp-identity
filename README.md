﻿### Đóng gói phiên bản mới

`dotnet pack -c Release`

### Đăng tải phiên bản mới lên NuGet.org

`dotnet nuget push bin/Release/THPIdentity.1.1.0.nupkg --api-key YOUR_API_KEY --source https://api.nuget.org/v3/index.json`