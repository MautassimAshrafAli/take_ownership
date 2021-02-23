# take_ownership

how to take ownership of windows system files programmatically and edit them.
using:
c#
cmd
note cmd(cacls):
/T            Changes access control lists(ACLs) of specified files in the current directory and all subdirectories.
/E            Edit ACL instead of replacing it.
/C            Continue on access denied errors.
/G user: perm  Grant specified user access rights.
 :N  None
        :R  Read
        :W  Write
        :C  Change (write)
        :F  Full control
