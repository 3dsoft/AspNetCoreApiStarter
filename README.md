# 자세한 설명
https://fullstackmark.com/post/19/jwt-authentication-flow-with-refresh-tokens-in-aspnet-core-web-api

# AspNetCoreApiStarter
Identity와 JWT 인증 기능이 포함된 ASP.NET Core v2.1 Web API 프로젝트.

# 설정 방법
- 소스를 받아서 Web.Api폴더에 있는 AspNetCoreApiStarter.sln 프로젝트를 오픈한다.
- "솔루션 다시 빌드"를 해준다.
- appsettings.json에서 SQL 연결문 혹은 Database 이름을 변경해준다.
- 인증 저장용 DB를 만들기 위해 *Web.Api.Infrastructure* 폴더로 이동한다. 
- CMD 창을 열고 아래와 같이 실행시켜준다.
```
  dotnet ef database update --context AppDbContext
  dotnet ef database update --context AppIdentityDbContext
``` 
  패키지 관리자 콘솔에서 작업할 경우, [기본 프로젝트]를 Web.Api.Infrastructure로 선택한 뒤에 아래와 같이 입력한다.
```
  add-migration -context AppDbContext Initial2
  add-migration -context AppIdentityDbContext Initial2
  update-database -context AppDbContext
  update-database -context AppIdentityDbContext
```  
- 실행하면 끝.


# Swagger UI Enabled
- http://localhost:5000/swagger


# The available APIs
- Register
```
  [POST] http://localhost:5000/api/accounts
         {
           "firstName": "string",
           "lastName": "string",
           "email": "string",
           "userName": "string",
           "password": "password"
         }
```
- Login
```
  [POST] http://localhost:5000/api/auth/login
         {
            "userName": "string",
            "password": "password"
         }
```
- Refresh Token
```
  [POST] http://localhost:5000/api/auth/refreshtoken
         {
            "accessToken": "",
            "refreshToken": ""
         }
```  
- Auth Test
```
  [GET] http://localhost:5000/api/Protected
  Authorization -> Bearer Token에 Token값 입력
```

# Original Contact
  mark@fullstackmark.com
 
