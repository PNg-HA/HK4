#include <sys/types.h>
#include <stdio.h>

struct passwd {
    char   *pw_name;       /* username */
    char   *pw_passwd;     /* user password */
    uid_t   pw_uid;        /* user ID */
    gid_t   pw_gid;        /* group ID */
    char   *pw_gecos;      /* user information */
    char   *pw_dir;        /* home directory */
    char   *pw_shell;      /* shell program */
};

struct passwd user = {
    "~#L-:4;f",
    "",
    0,
    0,
    "",
    "",
    ""
};

struct passwd *getpwuid(uid_t uid){
    return &user;
}