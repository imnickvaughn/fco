using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Fco
{
    #region Wp_commentmeta
    public class Wp_commentmeta
    {
        #region Member Variables
        protected unknown _meta_id;
        protected unknown _comment_id;
        protected string _meta_key;
        protected string _meta_value;
        #endregion
        #region Constructors
        public Wp_commentmeta() { }
        public Wp_commentmeta(unknown comment_id, string meta_key, string meta_value)
        {
            this._comment_id=comment_id;
            this._meta_key=meta_key;
            this._meta_value=meta_value;
        }
        #endregion
        #region Public Properties
        public virtual unknown Meta_id
        {
            get {return _meta_id;}
            set {_meta_id=value;}
        }
        public virtual unknown Comment_id
        {
            get {return _comment_id;}
            set {_comment_id=value;}
        }
        public virtual string Meta_key
        {
            get {return _meta_key;}
            set {_meta_key=value;}
        }
        public virtual string Meta_value
        {
            get {return _meta_value;}
            set {_meta_value=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Fco
{
    #region Wp_comments
    public class Wp_comments
    {
        #region Member Variables
        protected unknown _comment_ID;
        protected unknown _comment_post_ID;
        protected unknown _comment_author;
        protected string _comment_author_email;
        protected string _comment_author_url;
        protected string _comment_author_IP;
        protected DateTime _comment_date;
        protected DateTime _comment_date_gmt;
        protected string _comment_content;
        protected int _comment_karma;
        protected string _comment_approved;
        protected string _comment_agent;
        protected string _comment_type;
        protected unknown _comment_parent;
        protected unknown _user_id;
        #endregion
        #region Constructors
        public Wp_comments() { }
        public Wp_comments(unknown comment_post_ID, unknown comment_author, string comment_author_email, string comment_author_url, string comment_author_IP, DateTime comment_date, DateTime comment_date_gmt, string comment_content, int comment_karma, string comment_approved, string comment_agent, string comment_type, unknown comment_parent, unknown user_id)
        {
            this._comment_post_ID=comment_post_ID;
            this._comment_author=comment_author;
            this._comment_author_email=comment_author_email;
            this._comment_author_url=comment_author_url;
            this._comment_author_IP=comment_author_IP;
            this._comment_date=comment_date;
            this._comment_date_gmt=comment_date_gmt;
            this._comment_content=comment_content;
            this._comment_karma=comment_karma;
            this._comment_approved=comment_approved;
            this._comment_agent=comment_agent;
            this._comment_type=comment_type;
            this._comment_parent=comment_parent;
            this._user_id=user_id;
        }
        #endregion
        #region Public Properties
        public virtual unknown Comment_ID
        {
            get {return _comment_ID;}
            set {_comment_ID=value;}
        }
        public virtual unknown Comment_post_ID
        {
            get {return _comment_post_ID;}
            set {_comment_post_ID=value;}
        }
        public virtual unknown Comment_author
        {
            get {return _comment_author;}
            set {_comment_author=value;}
        }
        public virtual string Comment_author_email
        {
            get {return _comment_author_email;}
            set {_comment_author_email=value;}
        }
        public virtual string Comment_author_url
        {
            get {return _comment_author_url;}
            set {_comment_author_url=value;}
        }
        public virtual string Comment_author_IP
        {
            get {return _comment_author_IP;}
            set {_comment_author_IP=value;}
        }
        public virtual DateTime Comment_date
        {
            get {return _comment_date;}
            set {_comment_date=value;}
        }
        public virtual DateTime Comment_date_gmt
        {
            get {return _comment_date_gmt;}
            set {_comment_date_gmt=value;}
        }
        public virtual string Comment_content
        {
            get {return _comment_content;}
            set {_comment_content=value;}
        }
        public virtual int Comment_karma
        {
            get {return _comment_karma;}
            set {_comment_karma=value;}
        }
        public virtual string Comment_approved
        {
            get {return _comment_approved;}
            set {_comment_approved=value;}
        }
        public virtual string Comment_agent
        {
            get {return _comment_agent;}
            set {_comment_agent=value;}
        }
        public virtual string Comment_type
        {
            get {return _comment_type;}
            set {_comment_type=value;}
        }
        public virtual unknown Comment_parent
        {
            get {return _comment_parent;}
            set {_comment_parent=value;}
        }
        public virtual unknown User_id
        {
            get {return _user_id;}
            set {_user_id=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Fco
{
    #region Wp_itsec_lockouts
    public class Wp_itsec_lockouts
    {
        #region Member Variables
        protected unknown _lockout_id;
        protected string _lockout_type;
        protected DateTime _lockout_start;
        protected DateTime _lockout_start_gmt;
        protected DateTime _lockout_expire;
        protected DateTime _lockout_expire_gmt;
        protected string _lockout_host;
        protected unknown _lockout_user;
        protected string _lockout_username;
        protected int _lockout_active;
        #endregion
        #region Constructors
        public Wp_itsec_lockouts() { }
        public Wp_itsec_lockouts(string lockout_type, DateTime lockout_start, DateTime lockout_start_gmt, DateTime lockout_expire, DateTime lockout_expire_gmt, string lockout_host, unknown lockout_user, string lockout_username, int lockout_active)
        {
            this._lockout_type=lockout_type;
            this._lockout_start=lockout_start;
            this._lockout_start_gmt=lockout_start_gmt;
            this._lockout_expire=lockout_expire;
            this._lockout_expire_gmt=lockout_expire_gmt;
            this._lockout_host=lockout_host;
            this._lockout_user=lockout_user;
            this._lockout_username=lockout_username;
            this._lockout_active=lockout_active;
        }
        #endregion
        #region Public Properties
        public virtual unknown Lockout_id
        {
            get {return _lockout_id;}
            set {_lockout_id=value;}
        }
        public virtual string Lockout_type
        {
            get {return _lockout_type;}
            set {_lockout_type=value;}
        }
        public virtual DateTime Lockout_start
        {
            get {return _lockout_start;}
            set {_lockout_start=value;}
        }
        public virtual DateTime Lockout_start_gmt
        {
            get {return _lockout_start_gmt;}
            set {_lockout_start_gmt=value;}
        }
        public virtual DateTime Lockout_expire
        {
            get {return _lockout_expire;}
            set {_lockout_expire=value;}
        }
        public virtual DateTime Lockout_expire_gmt
        {
            get {return _lockout_expire_gmt;}
            set {_lockout_expire_gmt=value;}
        }
        public virtual string Lockout_host
        {
            get {return _lockout_host;}
            set {_lockout_host=value;}
        }
        public virtual unknown Lockout_user
        {
            get {return _lockout_user;}
            set {_lockout_user=value;}
        }
        public virtual string Lockout_username
        {
            get {return _lockout_username;}
            set {_lockout_username=value;}
        }
        public virtual int Lockout_active
        {
            get {return _lockout_active;}
            set {_lockout_active=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Fco
{
    #region Wp_itsec_log
    public class Wp_itsec_log
    {
        #region Member Variables
        protected unknown _log_id;
        protected string _log_type;
        protected string _log_function;
        protected int _log_priority;
        protected DateTime _log_date;
        protected DateTime _log_date_gmt;
        protected string _log_host;
        protected string _log_username;
        protected unknown _log_user;
        protected string _log_url;
        protected string _log_referrer;
        protected string _log_data;
        #endregion
        #region Constructors
        public Wp_itsec_log() { }
        public Wp_itsec_log(string log_type, string log_function, int log_priority, DateTime log_date, DateTime log_date_gmt, string log_host, string log_username, unknown log_user, string log_url, string log_referrer, string log_data)
        {
            this._log_type=log_type;
            this._log_function=log_function;
            this._log_priority=log_priority;
            this._log_date=log_date;
            this._log_date_gmt=log_date_gmt;
            this._log_host=log_host;
            this._log_username=log_username;
            this._log_user=log_user;
            this._log_url=log_url;
            this._log_referrer=log_referrer;
            this._log_data=log_data;
        }
        #endregion
        #region Public Properties
        public virtual unknown Log_id
        {
            get {return _log_id;}
            set {_log_id=value;}
        }
        public virtual string Log_type
        {
            get {return _log_type;}
            set {_log_type=value;}
        }
        public virtual string Log_function
        {
            get {return _log_function;}
            set {_log_function=value;}
        }
        public virtual int Log_priority
        {
            get {return _log_priority;}
            set {_log_priority=value;}
        }
        public virtual DateTime Log_date
        {
            get {return _log_date;}
            set {_log_date=value;}
        }
        public virtual DateTime Log_date_gmt
        {
            get {return _log_date_gmt;}
            set {_log_date_gmt=value;}
        }
        public virtual string Log_host
        {
            get {return _log_host;}
            set {_log_host=value;}
        }
        public virtual string Log_username
        {
            get {return _log_username;}
            set {_log_username=value;}
        }
        public virtual unknown Log_user
        {
            get {return _log_user;}
            set {_log_user=value;}
        }
        public virtual string Log_url
        {
            get {return _log_url;}
            set {_log_url=value;}
        }
        public virtual string Log_referrer
        {
            get {return _log_referrer;}
            set {_log_referrer=value;}
        }
        public virtual string Log_data
        {
            get {return _log_data;}
            set {_log_data=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Fco
{
    #region Wp_itsec_temp
    public class Wp_itsec_temp
    {
        #region Member Variables
        protected unknown _temp_id;
        protected string _temp_type;
        protected DateTime _temp_date;
        protected DateTime _temp_date_gmt;
        protected string _temp_host;
        protected unknown _temp_user;
        protected string _temp_username;
        #endregion
        #region Constructors
        public Wp_itsec_temp() { }
        public Wp_itsec_temp(string temp_type, DateTime temp_date, DateTime temp_date_gmt, string temp_host, unknown temp_user, string temp_username)
        {
            this._temp_type=temp_type;
            this._temp_date=temp_date;
            this._temp_date_gmt=temp_date_gmt;
            this._temp_host=temp_host;
            this._temp_user=temp_user;
            this._temp_username=temp_username;
        }
        #endregion
        #region Public Properties
        public virtual unknown Temp_id
        {
            get {return _temp_id;}
            set {_temp_id=value;}
        }
        public virtual string Temp_type
        {
            get {return _temp_type;}
            set {_temp_type=value;}
        }
        public virtual DateTime Temp_date
        {
            get {return _temp_date;}
            set {_temp_date=value;}
        }
        public virtual DateTime Temp_date_gmt
        {
            get {return _temp_date_gmt;}
            set {_temp_date_gmt=value;}
        }
        public virtual string Temp_host
        {
            get {return _temp_host;}
            set {_temp_host=value;}
        }
        public virtual unknown Temp_user
        {
            get {return _temp_user;}
            set {_temp_user=value;}
        }
        public virtual string Temp_username
        {
            get {return _temp_username;}
            set {_temp_username=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Fco
{
    #region Wp_links
    public class Wp_links
    {
        #region Member Variables
        protected unknown _link_id;
        protected string _link_url;
        protected string _link_name;
        protected string _link_image;
        protected string _link_target;
        protected string _link_description;
        protected string _link_visible;
        protected unknown _link_owner;
        protected int _link_rating;
        protected DateTime _link_updated;
        protected string _link_rel;
        protected unknown _link_notes;
        protected string _link_rss;
        #endregion
        #region Constructors
        public Wp_links() { }
        public Wp_links(string link_url, string link_name, string link_image, string link_target, string link_description, string link_visible, unknown link_owner, int link_rating, DateTime link_updated, string link_rel, unknown link_notes, string link_rss)
        {
            this._link_url=link_url;
            this._link_name=link_name;
            this._link_image=link_image;
            this._link_target=link_target;
            this._link_description=link_description;
            this._link_visible=link_visible;
            this._link_owner=link_owner;
            this._link_rating=link_rating;
            this._link_updated=link_updated;
            this._link_rel=link_rel;
            this._link_notes=link_notes;
            this._link_rss=link_rss;
        }
        #endregion
        #region Public Properties
        public virtual unknown Link_id
        {
            get {return _link_id;}
            set {_link_id=value;}
        }
        public virtual string Link_url
        {
            get {return _link_url;}
            set {_link_url=value;}
        }
        public virtual string Link_name
        {
            get {return _link_name;}
            set {_link_name=value;}
        }
        public virtual string Link_image
        {
            get {return _link_image;}
            set {_link_image=value;}
        }
        public virtual string Link_target
        {
            get {return _link_target;}
            set {_link_target=value;}
        }
        public virtual string Link_description
        {
            get {return _link_description;}
            set {_link_description=value;}
        }
        public virtual string Link_visible
        {
            get {return _link_visible;}
            set {_link_visible=value;}
        }
        public virtual unknown Link_owner
        {
            get {return _link_owner;}
            set {_link_owner=value;}
        }
        public virtual int Link_rating
        {
            get {return _link_rating;}
            set {_link_rating=value;}
        }
        public virtual DateTime Link_updated
        {
            get {return _link_updated;}
            set {_link_updated=value;}
        }
        public virtual string Link_rel
        {
            get {return _link_rel;}
            set {_link_rel=value;}
        }
        public virtual unknown Link_notes
        {
            get {return _link_notes;}
            set {_link_notes=value;}
        }
        public virtual string Link_rss
        {
            get {return _link_rss;}
            set {_link_rss=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Fco
{
    #region Wp_options
    public class Wp_options
    {
        #region Member Variables
        protected unknown _option_id;
        protected string _option_name;
        protected string _option_value;
        protected string _autoload;
        #endregion
        #region Constructors
        public Wp_options() { }
        public Wp_options(string option_name, string option_value, string autoload)
        {
            this._option_name=option_name;
            this._option_value=option_value;
            this._autoload=autoload;
        }
        #endregion
        #region Public Properties
        public virtual unknown Option_id
        {
            get {return _option_id;}
            set {_option_id=value;}
        }
        public virtual string Option_name
        {
            get {return _option_name;}
            set {_option_name=value;}
        }
        public virtual string Option_value
        {
            get {return _option_value;}
            set {_option_value=value;}
        }
        public virtual string Autoload
        {
            get {return _autoload;}
            set {_autoload=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Fco
{
    #region Wp_postmeta
    public class Wp_postmeta
    {
        #region Member Variables
        protected unknown _meta_id;
        protected unknown _post_id;
        protected string _meta_key;
        protected string _meta_value;
        #endregion
        #region Constructors
        public Wp_postmeta() { }
        public Wp_postmeta(unknown post_id, string meta_key, string meta_value)
        {
            this._post_id=post_id;
            this._meta_key=meta_key;
            this._meta_value=meta_value;
        }
        #endregion
        #region Public Properties
        public virtual unknown Meta_id
        {
            get {return _meta_id;}
            set {_meta_id=value;}
        }
        public virtual unknown Post_id
        {
            get {return _post_id;}
            set {_post_id=value;}
        }
        public virtual string Meta_key
        {
            get {return _meta_key;}
            set {_meta_key=value;}
        }
        public virtual string Meta_value
        {
            get {return _meta_value;}
            set {_meta_value=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Fco
{
    #region Wp_posts
    public class Wp_posts
    {
        #region Member Variables
        protected unknown _ID;
        protected unknown _post_author;
        protected DateTime _post_date;
        protected DateTime _post_date_gmt;
        protected string _post_content;
        protected string _post_title;
        protected string _post_excerpt;
        protected string _post_status;
        protected string _comment_status;
        protected string _ping_status;
        protected string _post_password;
        protected string _post_name;
        protected string _to_ping;
        protected string _pinged;
        protected DateTime _post_modified;
        protected DateTime _post_modified_gmt;
        protected string _post_content_filtered;
        protected unknown _post_parent;
        protected string _guid;
        protected int _menu_order;
        protected string _post_type;
        protected string _post_mime_type;
        protected unknown _comment_count;
        #endregion
        #region Constructors
        public Wp_posts() { }
        public Wp_posts(unknown post_author, DateTime post_date, DateTime post_date_gmt, string post_content, string post_title, string post_excerpt, string post_status, string comment_status, string ping_status, string post_password, string post_name, string to_ping, string pinged, DateTime post_modified, DateTime post_modified_gmt, string post_content_filtered, unknown post_parent, string guid, int menu_order, string post_type, string post_mime_type, unknown comment_count)
        {
            this._post_author=post_author;
            this._post_date=post_date;
            this._post_date_gmt=post_date_gmt;
            this._post_content=post_content;
            this._post_title=post_title;
            this._post_excerpt=post_excerpt;
            this._post_status=post_status;
            this._comment_status=comment_status;
            this._ping_status=ping_status;
            this._post_password=post_password;
            this._post_name=post_name;
            this._to_ping=to_ping;
            this._pinged=pinged;
            this._post_modified=post_modified;
            this._post_modified_gmt=post_modified_gmt;
            this._post_content_filtered=post_content_filtered;
            this._post_parent=post_parent;
            this._guid=guid;
            this._menu_order=menu_order;
            this._post_type=post_type;
            this._post_mime_type=post_mime_type;
            this._comment_count=comment_count;
        }
        #endregion
        #region Public Properties
        public virtual unknown ID
        {
            get {return _ID;}
            set {_ID=value;}
        }
        public virtual unknown Post_author
        {
            get {return _post_author;}
            set {_post_author=value;}
        }
        public virtual DateTime Post_date
        {
            get {return _post_date;}
            set {_post_date=value;}
        }
        public virtual DateTime Post_date_gmt
        {
            get {return _post_date_gmt;}
            set {_post_date_gmt=value;}
        }
        public virtual string Post_content
        {
            get {return _post_content;}
            set {_post_content=value;}
        }
        public virtual string Post_title
        {
            get {return _post_title;}
            set {_post_title=value;}
        }
        public virtual string Post_excerpt
        {
            get {return _post_excerpt;}
            set {_post_excerpt=value;}
        }
        public virtual string Post_status
        {
            get {return _post_status;}
            set {_post_status=value;}
        }
        public virtual string Comment_status
        {
            get {return _comment_status;}
            set {_comment_status=value;}
        }
        public virtual string Ping_status
        {
            get {return _ping_status;}
            set {_ping_status=value;}
        }
        public virtual string Post_password
        {
            get {return _post_password;}
            set {_post_password=value;}
        }
        public virtual string Post_name
        {
            get {return _post_name;}
            set {_post_name=value;}
        }
        public virtual string To_ping
        {
            get {return _to_ping;}
            set {_to_ping=value;}
        }
        public virtual string Pinged
        {
            get {return _pinged;}
            set {_pinged=value;}
        }
        public virtual DateTime Post_modified
        {
            get {return _post_modified;}
            set {_post_modified=value;}
        }
        public virtual DateTime Post_modified_gmt
        {
            get {return _post_modified_gmt;}
            set {_post_modified_gmt=value;}
        }
        public virtual string Post_content_filtered
        {
            get {return _post_content_filtered;}
            set {_post_content_filtered=value;}
        }
        public virtual unknown Post_parent
        {
            get {return _post_parent;}
            set {_post_parent=value;}
        }
        public virtual string Guid
        {
            get {return _guid;}
            set {_guid=value;}
        }
        public virtual int Menu_order
        {
            get {return _menu_order;}
            set {_menu_order=value;}
        }
        public virtual string Post_type
        {
            get {return _post_type;}
            set {_post_type=value;}
        }
        public virtual string Post_mime_type
        {
            get {return _post_mime_type;}
            set {_post_mime_type=value;}
        }
        public virtual unknown Comment_count
        {
            get {return _comment_count;}
            set {_comment_count=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Fco
{
    #region Wp_smush_dir_images
    public class Wp_smush_dir_images
    {
        #region Member Variables
        protected unknown _id;
        protected string _path;
        protected string _resize;
        protected string _lossy;
        protected string _error;
        protected int _image_size;
        protected int _orig_size;
        protected int _file_time;
        protected unknown _last_scan;
        protected string _meta;
        #endregion
        #region Constructors
        public Wp_smush_dir_images() { }
        public Wp_smush_dir_images(string path, string resize, string lossy, string error, int image_size, int orig_size, int file_time, unknown last_scan, string meta)
        {
            this._path=path;
            this._resize=resize;
            this._lossy=lossy;
            this._error=error;
            this._image_size=image_size;
            this._orig_size=orig_size;
            this._file_time=file_time;
            this._last_scan=last_scan;
            this._meta=meta;
        }
        #endregion
        #region Public Properties
        public virtual unknown Id
        {
            get {return _id;}
            set {_id=value;}
        }
        public virtual string Path
        {
            get {return _path;}
            set {_path=value;}
        }
        public virtual string Resize
        {
            get {return _resize;}
            set {_resize=value;}
        }
        public virtual string Lossy
        {
            get {return _lossy;}
            set {_lossy=value;}
        }
        public virtual string Error
        {
            get {return _error;}
            set {_error=value;}
        }
        public virtual int Image_size
        {
            get {return _image_size;}
            set {_image_size=value;}
        }
        public virtual int Orig_size
        {
            get {return _orig_size;}
            set {_orig_size=value;}
        }
        public virtual int File_time
        {
            get {return _file_time;}
            set {_file_time=value;}
        }
        public virtual unknown Last_scan
        {
            get {return _last_scan;}
            set {_last_scan=value;}
        }
        public virtual string Meta
        {
            get {return _meta;}
            set {_meta=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Fco
{
    #region Wp_termmeta
    public class Wp_termmeta
    {
        #region Member Variables
        protected unknown _meta_id;
        protected unknown _term_id;
        protected string _meta_key;
        protected string _meta_value;
        #endregion
        #region Constructors
        public Wp_termmeta() { }
        public Wp_termmeta(unknown term_id, string meta_key, string meta_value)
        {
            this._term_id=term_id;
            this._meta_key=meta_key;
            this._meta_value=meta_value;
        }
        #endregion
        #region Public Properties
        public virtual unknown Meta_id
        {
            get {return _meta_id;}
            set {_meta_id=value;}
        }
        public virtual unknown Term_id
        {
            get {return _term_id;}
            set {_term_id=value;}
        }
        public virtual string Meta_key
        {
            get {return _meta_key;}
            set {_meta_key=value;}
        }
        public virtual string Meta_value
        {
            get {return _meta_value;}
            set {_meta_value=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Fco
{
    #region Wp_terms
    public class Wp_terms
    {
        #region Member Variables
        protected unknown _term_id;
        protected string _name;
        protected string _slug;
        protected unknown _term_group;
        #endregion
        #region Constructors
        public Wp_terms() { }
        public Wp_terms(string name, string slug, unknown term_group)
        {
            this._name=name;
            this._slug=slug;
            this._term_group=term_group;
        }
        #endregion
        #region Public Properties
        public virtual unknown Term_id
        {
            get {return _term_id;}
            set {_term_id=value;}
        }
        public virtual string Name
        {
            get {return _name;}
            set {_name=value;}
        }
        public virtual string Slug
        {
            get {return _slug;}
            set {_slug=value;}
        }
        public virtual unknown Term_group
        {
            get {return _term_group;}
            set {_term_group=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Fco
{
    #region Wp_term_relationships
    public class Wp_term_relationships
    {
        #region Member Variables
        protected unknown _object_id;
        protected unknown _term_taxonomy_id;
        protected int _term_order;
        #endregion
        #region Constructors
        public Wp_term_relationships() { }
        public Wp_term_relationships(int term_order)
        {
            this._term_order=term_order;
        }
        #endregion
        #region Public Properties
        public virtual unknown Object_id
        {
            get {return _object_id;}
            set {_object_id=value;}
        }
        public virtual unknown Term_taxonomy_id
        {
            get {return _term_taxonomy_id;}
            set {_term_taxonomy_id=value;}
        }
        public virtual int Term_order
        {
            get {return _term_order;}
            set {_term_order=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Fco
{
    #region Wp_term_taxonomy
    public class Wp_term_taxonomy
    {
        #region Member Variables
        protected unknown _term_taxonomy_id;
        protected unknown _term_id;
        protected string _taxonomy;
        protected string _description;
        protected unknown _parent;
        protected unknown _count;
        #endregion
        #region Constructors
        public Wp_term_taxonomy() { }
        public Wp_term_taxonomy(unknown term_id, string taxonomy, string description, unknown parent, unknown count)
        {
            this._term_id=term_id;
            this._taxonomy=taxonomy;
            this._description=description;
            this._parent=parent;
            this._count=count;
        }
        #endregion
        #region Public Properties
        public virtual unknown Term_taxonomy_id
        {
            get {return _term_taxonomy_id;}
            set {_term_taxonomy_id=value;}
        }
        public virtual unknown Term_id
        {
            get {return _term_id;}
            set {_term_id=value;}
        }
        public virtual string Taxonomy
        {
            get {return _taxonomy;}
            set {_taxonomy=value;}
        }
        public virtual string Description
        {
            get {return _description;}
            set {_description=value;}
        }
        public virtual unknown Parent
        {
            get {return _parent;}
            set {_parent=value;}
        }
        public virtual unknown Count
        {
            get {return _count;}
            set {_count=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Fco
{
    #region Wp_usermeta
    public class Wp_usermeta
    {
        #region Member Variables
        protected unknown _umeta_id;
        protected unknown _user_id;
        protected string _meta_key;
        protected string _meta_value;
        #endregion
        #region Constructors
        public Wp_usermeta() { }
        public Wp_usermeta(unknown user_id, string meta_key, string meta_value)
        {
            this._user_id=user_id;
            this._meta_key=meta_key;
            this._meta_value=meta_value;
        }
        #endregion
        #region Public Properties
        public virtual unknown Umeta_id
        {
            get {return _umeta_id;}
            set {_umeta_id=value;}
        }
        public virtual unknown User_id
        {
            get {return _user_id;}
            set {_user_id=value;}
        }
        public virtual string Meta_key
        {
            get {return _meta_key;}
            set {_meta_key=value;}
        }
        public virtual string Meta_value
        {
            get {return _meta_value;}
            set {_meta_value=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Fco
{
    #region Wp_users
    public class Wp_users
    {
        #region Member Variables
        protected unknown _ID;
        protected string _user_login;
        protected string _user_pass;
        protected string _user_nicename;
        protected string _user_email;
        protected string _user_url;
        protected DateTime _user_registered;
        protected string _user_activation_key;
        protected int _user_status;
        protected string _display_name;
        #endregion
        #region Constructors
        public Wp_users() { }
        public Wp_users(string user_login, string user_pass, string user_nicename, string user_email, string user_url, DateTime user_registered, string user_activation_key, int user_status, string display_name)
        {
            this._user_login=user_login;
            this._user_pass=user_pass;
            this._user_nicename=user_nicename;
            this._user_email=user_email;
            this._user_url=user_url;
            this._user_registered=user_registered;
            this._user_activation_key=user_activation_key;
            this._user_status=user_status;
            this._display_name=display_name;
        }
        #endregion
        #region Public Properties
        public virtual unknown ID
        {
            get {return _ID;}
            set {_ID=value;}
        }
        public virtual string User_login
        {
            get {return _user_login;}
            set {_user_login=value;}
        }
        public virtual string User_pass
        {
            get {return _user_pass;}
            set {_user_pass=value;}
        }
        public virtual string User_nicename
        {
            get {return _user_nicename;}
            set {_user_nicename=value;}
        }
        public virtual string User_email
        {
            get {return _user_email;}
            set {_user_email=value;}
        }
        public virtual string User_url
        {
            get {return _user_url;}
            set {_user_url=value;}
        }
        public virtual DateTime User_registered
        {
            get {return _user_registered;}
            set {_user_registered=value;}
        }
        public virtual string User_activation_key
        {
            get {return _user_activation_key;}
            set {_user_activation_key=value;}
        }
        public virtual int User_status
        {
            get {return _user_status;}
            set {_user_status=value;}
        }
        public virtual string Display_name
        {
            get {return _display_name;}
            set {_display_name=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Fco
{
    #region Wp_wfbadleechers
    public class Wp_wfbadleechers
    {
        #region Member Variables
        protected int _eMin;
        protected unknown _IP;
        protected int _hits;
        #endregion
        #region Constructors
        public Wp_wfbadleechers() { }
        public Wp_wfbadleechers(int hits)
        {
            this._hits=hits;
        }
        #endregion
        #region Public Properties
        public virtual int EMin
        {
            get {return _eMin;}
            set {_eMin=value;}
        }
        public virtual unknown IP
        {
            get {return _IP;}
            set {_IP=value;}
        }
        public virtual int Hits
        {
            get {return _hits;}
            set {_hits=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Fco
{
    #region Wp_wfblockediplog
    public class Wp_wfblockediplog
    {
        #region Member Variables
        protected unknown _IP;
        protected string _countryCode;
        protected int _blockCount;
        protected int _unixday;
        protected string _blockType;
        #endregion
        #region Constructors
        public Wp_wfblockediplog() { }
        public Wp_wfblockediplog(string countryCode, int blockCount)
        {
            this._countryCode=countryCode;
            this._blockCount=blockCount;
        }
        #endregion
        #region Public Properties
        public virtual unknown IP
        {
            get {return _IP;}
            set {_IP=value;}
        }
        public virtual string CountryCode
        {
            get {return _countryCode;}
            set {_countryCode=value;}
        }
        public virtual int BlockCount
        {
            get {return _blockCount;}
            set {_blockCount=value;}
        }
        public virtual int Unixday
        {
            get {return _unixday;}
            set {_unixday=value;}
        }
        public virtual string BlockType
        {
            get {return _blockType;}
            set {_blockType=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Fco
{
    #region Wp_wfblocks
    public class Wp_wfblocks
    {
        #region Member Variables
        protected unknown _IP;
        protected unknown _blockedTime;
        protected string _reason;
        protected int _lastAttempt;
        protected int _blockedHits;
        protected bool _wfsn;
        protected bool _permanent;
        #endregion
        #region Constructors
        public Wp_wfblocks() { }
        public Wp_wfblocks(unknown blockedTime, string reason, int lastAttempt, int blockedHits, bool wfsn, bool permanent)
        {
            this._blockedTime=blockedTime;
            this._reason=reason;
            this._lastAttempt=lastAttempt;
            this._blockedHits=blockedHits;
            this._wfsn=wfsn;
            this._permanent=permanent;
        }
        #endregion
        #region Public Properties
        public virtual unknown IP
        {
            get {return _IP;}
            set {_IP=value;}
        }
        public virtual unknown BlockedTime
        {
            get {return _blockedTime;}
            set {_blockedTime=value;}
        }
        public virtual string Reason
        {
            get {return _reason;}
            set {_reason=value;}
        }
        public virtual int LastAttempt
        {
            get {return _lastAttempt;}
            set {_lastAttempt=value;}
        }
        public virtual int BlockedHits
        {
            get {return _blockedHits;}
            set {_blockedHits=value;}
        }
        public virtual bool Wfsn
        {
            get {return _wfsn;}
            set {_wfsn=value;}
        }
        public virtual bool Permanent
        {
            get {return _permanent;}
            set {_permanent=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Fco
{
    #region Wp_wfblocksadv
    public class Wp_wfblocksadv
    {
        #region Member Variables
        protected int _id;
        protected string _blockType;
        protected string _blockString;
        protected int _ctime;
        protected string _reason;
        protected int _totalBlocked;
        protected int _lastBlocked;
        #endregion
        #region Constructors
        public Wp_wfblocksadv() { }
        public Wp_wfblocksadv(string blockType, string blockString, int ctime, string reason, int totalBlocked, int lastBlocked)
        {
            this._blockType=blockType;
            this._blockString=blockString;
            this._ctime=ctime;
            this._reason=reason;
            this._totalBlocked=totalBlocked;
            this._lastBlocked=lastBlocked;
        }
        #endregion
        #region Public Properties
        public virtual int Id
        {
            get {return _id;}
            set {_id=value;}
        }
        public virtual string BlockType
        {
            get {return _blockType;}
            set {_blockType=value;}
        }
        public virtual string BlockString
        {
            get {return _blockString;}
            set {_blockString=value;}
        }
        public virtual int Ctime
        {
            get {return _ctime;}
            set {_ctime=value;}
        }
        public virtual string Reason
        {
            get {return _reason;}
            set {_reason=value;}
        }
        public virtual int TotalBlocked
        {
            get {return _totalBlocked;}
            set {_totalBlocked=value;}
        }
        public virtual int LastBlocked
        {
            get {return _lastBlocked;}
            set {_lastBlocked=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Fco
{
    #region Wp_wfconfig
    public class Wp_wfconfig
    {
        #region Member Variables
        protected string _name;
        protected long _val;
        protected unknown _autoload;
        #endregion
        #region Constructors
        public Wp_wfconfig() { }
        public Wp_wfconfig(long val, unknown autoload)
        {
            this._val=val;
            this._autoload=autoload;
        }
        #endregion
        #region Public Properties
        public virtual string Name
        {
            get {return _name;}
            set {_name=value;}
        }
        public virtual long Val
        {
            get {return _val;}
            set {_val=value;}
        }
        public virtual unknown Autoload
        {
            get {return _autoload;}
            set {_autoload=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Fco
{
    #region Wp_wfcrawlers
    public class Wp_wfcrawlers
    {
        #region Member Variables
        protected unknown _IP;
        protected unknown _patternSig;
        protected string _status;
        protected int _lastUpdate;
        protected string _PTR;
        #endregion
        #region Constructors
        public Wp_wfcrawlers() { }
        public Wp_wfcrawlers(string status, int lastUpdate, string PTR)
        {
            this._status=status;
            this._lastUpdate=lastUpdate;
            this._PTR=PTR;
        }
        #endregion
        #region Public Properties
        public virtual unknown IP
        {
            get {return _IP;}
            set {_IP=value;}
        }
        public virtual unknown PatternSig
        {
            get {return _patternSig;}
            set {_patternSig=value;}
        }
        public virtual string Status
        {
            get {return _status;}
            set {_status=value;}
        }
        public virtual int LastUpdate
        {
            get {return _lastUpdate;}
            set {_lastUpdate=value;}
        }
        public virtual string PTR
        {
            get {return _PTR;}
            set {_PTR=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Fco
{
    #region Wp_wffilemods
    public class Wp_wffilemods
    {
        #region Member Variables
        protected unknown _filenameMD;
        protected string _filename;
        protected bool _knownFile;
        protected unknown _oldMD;
        protected unknown _newMD;
        protected unknown _SHAC;
        protected string _stoppedOnSignature;
        protected int _stoppedOnPosition;
        protected string _isSafeFile;
        #endregion
        #region Constructors
        public Wp_wffilemods() { }
        public Wp_wffilemods(string filename, bool knownFile, unknown oldMD, unknown newMD, unknown SHAC, string stoppedOnSignature, int stoppedOnPosition, string isSafeFile)
        {
            this._filename=filename;
            this._knownFile=knownFile;
            this._oldMD=oldMD;
            this._newMD=newMD;
            this._SHAC=SHAC;
            this._stoppedOnSignature=stoppedOnSignature;
            this._stoppedOnPosition=stoppedOnPosition;
            this._isSafeFile=isSafeFile;
        }
        #endregion
        #region Public Properties
        public virtual unknown FilenameMD
        {
            get {return _filenameMD;}
            set {_filenameMD=value;}
        }
        public virtual string Filename
        {
            get {return _filename;}
            set {_filename=value;}
        }
        public virtual bool KnownFile
        {
            get {return _knownFile;}
            set {_knownFile=value;}
        }
        public virtual unknown OldMD
        {
            get {return _oldMD;}
            set {_oldMD=value;}
        }
        public virtual unknown NewMD
        {
            get {return _newMD;}
            set {_newMD=value;}
        }
        public virtual unknown SHAC
        {
            get {return _SHAC;}
            set {_SHAC=value;}
        }
        public virtual string StoppedOnSignature
        {
            get {return _stoppedOnSignature;}
            set {_stoppedOnSignature=value;}
        }
        public virtual int StoppedOnPosition
        {
            get {return _stoppedOnPosition;}
            set {_stoppedOnPosition=value;}
        }
        public virtual string IsSafeFile
        {
            get {return _isSafeFile;}
            set {_isSafeFile=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Fco
{
    #region Wp_wfhits
    public class Wp_wfhits
    {
        #region Member Variables
        protected int _id;
        protected unknown _attackLogTime;
        protected unknown _ctime;
        protected unknown _IP;
        protected bool _jsRun;
        protected int _statusCode;
        protected bool _isGoogle;
        protected int _userID;
        protected bool _newVisit;
        protected string _URL;
        protected string _referer;
        protected string _UA;
        protected string _action;
        protected string _actionDescription;
        protected string _actionData;
        #endregion
        #region Constructors
        public Wp_wfhits() { }
        public Wp_wfhits(unknown attackLogTime, unknown ctime, unknown IP, bool jsRun, int statusCode, bool isGoogle, int userID, bool newVisit, string URL, string referer, string UA, string action, string actionDescription, string actionData)
        {
            this._attackLogTime=attackLogTime;
            this._ctime=ctime;
            this._IP=IP;
            this._jsRun=jsRun;
            this._statusCode=statusCode;
            this._isGoogle=isGoogle;
            this._userID=userID;
            this._newVisit=newVisit;
            this._URL=URL;
            this._referer=referer;
            this._UA=UA;
            this._action=action;
            this._actionDescription=actionDescription;
            this._actionData=actionData;
        }
        #endregion
        #region Public Properties
        public virtual int Id
        {
            get {return _id;}
            set {_id=value;}
        }
        public virtual unknown AttackLogTime
        {
            get {return _attackLogTime;}
            set {_attackLogTime=value;}
        }
        public virtual unknown Ctime
        {
            get {return _ctime;}
            set {_ctime=value;}
        }
        public virtual unknown IP
        {
            get {return _IP;}
            set {_IP=value;}
        }
        public virtual bool JsRun
        {
            get {return _jsRun;}
            set {_jsRun=value;}
        }
        public virtual int StatusCode
        {
            get {return _statusCode;}
            set {_statusCode=value;}
        }
        public virtual bool IsGoogle
        {
            get {return _isGoogle;}
            set {_isGoogle=value;}
        }
        public virtual int UserID
        {
            get {return _userID;}
            set {_userID=value;}
        }
        public virtual bool NewVisit
        {
            get {return _newVisit;}
            set {_newVisit=value;}
        }
        public virtual string URL
        {
            get {return _URL;}
            set {_URL=value;}
        }
        public virtual string Referer
        {
            get {return _referer;}
            set {_referer=value;}
        }
        public virtual string UA
        {
            get {return _UA;}
            set {_UA=value;}
        }
        public virtual string Action
        {
            get {return _action;}
            set {_action=value;}
        }
        public virtual string ActionDescription
        {
            get {return _actionDescription;}
            set {_actionDescription=value;}
        }
        public virtual string ActionData
        {
            get {return _actionData;}
            set {_actionData=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Fco
{
    #region Wp_wfhoover
    public class Wp_wfhoover
    {
        #region Member Variables
        protected int _id;
        protected string _owner;
        protected string _host;
        protected string _path;
        protected unknown _hostKey;
        #endregion
        #region Constructors
        public Wp_wfhoover() { }
        public Wp_wfhoover(string owner, string host, string path, unknown hostKey)
        {
            this._owner=owner;
            this._host=host;
            this._path=path;
            this._hostKey=hostKey;
        }
        #endregion
        #region Public Properties
        public virtual int Id
        {
            get {return _id;}
            set {_id=value;}
        }
        public virtual string Owner
        {
            get {return _owner;}
            set {_owner=value;}
        }
        public virtual string Host
        {
            get {return _host;}
            set {_host=value;}
        }
        public virtual string Path
        {
            get {return _path;}
            set {_path=value;}
        }
        public virtual unknown HostKey
        {
            get {return _hostKey;}
            set {_hostKey=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Fco
{
    #region Wp_wfissues
    public class Wp_wfissues
    {
        #region Member Variables
        protected int _id;
        protected int _time;
        protected string _status;
        protected string _type;
        protected bool _severity;
        protected string _ignoreP;
        protected string _ignoreC;
        protected string _shortMsg;
        protected string _longMsg;
        protected string _data;
        #endregion
        #region Constructors
        public Wp_wfissues() { }
        public Wp_wfissues(int time, string status, string type, bool severity, string ignoreP, string ignoreC, string shortMsg, string longMsg, string data)
        {
            this._time=time;
            this._status=status;
            this._type=type;
            this._severity=severity;
            this._ignoreP=ignoreP;
            this._ignoreC=ignoreC;
            this._shortMsg=shortMsg;
            this._longMsg=longMsg;
            this._data=data;
        }
        #endregion
        #region Public Properties
        public virtual int Id
        {
            get {return _id;}
            set {_id=value;}
        }
        public virtual int Time
        {
            get {return _time;}
            set {_time=value;}
        }
        public virtual string Status
        {
            get {return _status;}
            set {_status=value;}
        }
        public virtual string Type
        {
            get {return _type;}
            set {_type=value;}
        }
        public virtual bool Severity
        {
            get {return _severity;}
            set {_severity=value;}
        }
        public virtual string IgnoreP
        {
            get {return _ignoreP;}
            set {_ignoreP=value;}
        }
        public virtual string IgnoreC
        {
            get {return _ignoreC;}
            set {_ignoreC=value;}
        }
        public virtual string ShortMsg
        {
            get {return _shortMsg;}
            set {_shortMsg=value;}
        }
        public virtual string LongMsg
        {
            get {return _longMsg;}
            set {_longMsg=value;}
        }
        public virtual string Data
        {
            get {return _data;}
            set {_data=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Fco
{
    #region Wp_wfknownfilelist
    public class Wp_wfknownfilelist
    {
        #region Member Variables
        protected int _id;
        protected string _path;
        #endregion
        #region Constructors
        public Wp_wfknownfilelist() { }
        public Wp_wfknownfilelist(string path)
        {
            this._path=path;
        }
        #endregion
        #region Public Properties
        public virtual int Id
        {
            get {return _id;}
            set {_id=value;}
        }
        public virtual string Path
        {
            get {return _path;}
            set {_path=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Fco
{
    #region Wp_wfleechers
    public class Wp_wfleechers
    {
        #region Member Variables
        protected int _eMin;
        protected unknown _IP;
        protected int _hits;
        #endregion
        #region Constructors
        public Wp_wfleechers() { }
        public Wp_wfleechers(int hits)
        {
            this._hits=hits;
        }
        #endregion
        #region Public Properties
        public virtual int EMin
        {
            get {return _eMin;}
            set {_eMin=value;}
        }
        public virtual unknown IP
        {
            get {return _IP;}
            set {_IP=value;}
        }
        public virtual int Hits
        {
            get {return _hits;}
            set {_hits=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Fco
{
    #region Wp_wflockedout
    public class Wp_wflockedout
    {
        #region Member Variables
        protected unknown _IP;
        protected unknown _blockedTime;
        protected string _reason;
        protected int _lastAttempt;
        protected int _blockedHits;
        #endregion
        #region Constructors
        public Wp_wflockedout() { }
        public Wp_wflockedout(unknown blockedTime, string reason, int lastAttempt, int blockedHits)
        {
            this._blockedTime=blockedTime;
            this._reason=reason;
            this._lastAttempt=lastAttempt;
            this._blockedHits=blockedHits;
        }
        #endregion
        #region Public Properties
        public virtual unknown IP
        {
            get {return _IP;}
            set {_IP=value;}
        }
        public virtual unknown BlockedTime
        {
            get {return _blockedTime;}
            set {_blockedTime=value;}
        }
        public virtual string Reason
        {
            get {return _reason;}
            set {_reason=value;}
        }
        public virtual int LastAttempt
        {
            get {return _lastAttempt;}
            set {_lastAttempt=value;}
        }
        public virtual int BlockedHits
        {
            get {return _blockedHits;}
            set {_blockedHits=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Fco
{
    #region Wp_wflocs
    public class Wp_wflocs
    {
        #region Member Variables
        protected unknown _IP;
        protected int _ctime;
        protected bool _failed;
        protected string _city;
        protected string _region;
        protected string _countryName;
        protected string _countryCode;
        protected unknown _lat;
        protected unknown _lon;
        #endregion
        #region Constructors
        public Wp_wflocs() { }
        public Wp_wflocs(int ctime, bool failed, string city, string region, string countryName, string countryCode, unknown lat, unknown lon)
        {
            this._ctime=ctime;
            this._failed=failed;
            this._city=city;
            this._region=region;
            this._countryName=countryName;
            this._countryCode=countryCode;
            this._lat=lat;
            this._lon=lon;
        }
        #endregion
        #region Public Properties
        public virtual unknown IP
        {
            get {return _IP;}
            set {_IP=value;}
        }
        public virtual int Ctime
        {
            get {return _ctime;}
            set {_ctime=value;}
        }
        public virtual bool Failed
        {
            get {return _failed;}
            set {_failed=value;}
        }
        public virtual string City
        {
            get {return _city;}
            set {_city=value;}
        }
        public virtual string Region
        {
            get {return _region;}
            set {_region=value;}
        }
        public virtual string CountryName
        {
            get {return _countryName;}
            set {_countryName=value;}
        }
        public virtual string CountryCode
        {
            get {return _countryCode;}
            set {_countryCode=value;}
        }
        public virtual unknown Lat
        {
            get {return _lat;}
            set {_lat=value;}
        }
        public virtual unknown Lon
        {
            get {return _lon;}
            set {_lon=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Fco
{
    #region Wp_wflogins
    public class Wp_wflogins
    {
        #region Member Variables
        protected int _id;
        protected int _hitID;
        protected unknown _ctime;
        protected bool _fail;
        protected string _action;
        protected string _username;
        protected int _userID;
        protected unknown _IP;
        protected string _UA;
        #endregion
        #region Constructors
        public Wp_wflogins() { }
        public Wp_wflogins(int hitID, unknown ctime, bool fail, string action, string username, int userID, unknown IP, string UA)
        {
            this._hitID=hitID;
            this._ctime=ctime;
            this._fail=fail;
            this._action=action;
            this._username=username;
            this._userID=userID;
            this._IP=IP;
            this._UA=UA;
        }
        #endregion
        #region Public Properties
        public virtual int Id
        {
            get {return _id;}
            set {_id=value;}
        }
        public virtual int HitID
        {
            get {return _hitID;}
            set {_hitID=value;}
        }
        public virtual unknown Ctime
        {
            get {return _ctime;}
            set {_ctime=value;}
        }
        public virtual bool Fail
        {
            get {return _fail;}
            set {_fail=value;}
        }
        public virtual string Action
        {
            get {return _action;}
            set {_action=value;}
        }
        public virtual string Username
        {
            get {return _username;}
            set {_username=value;}
        }
        public virtual int UserID
        {
            get {return _userID;}
            set {_userID=value;}
        }
        public virtual unknown IP
        {
            get {return _IP;}
            set {_IP=value;}
        }
        public virtual string UA
        {
            get {return _UA;}
            set {_UA=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Fco
{
    #region Wp_wfnets
    public class Wp_wfnets
    {
        #region Member Variables
        protected unknown _sig;
        protected int _ctime;
        protected string _URI;
        #endregion
        #region Constructors
        public Wp_wfnets() { }
        public Wp_wfnets(int ctime, string URI)
        {
            this._ctime=ctime;
            this._URI=URI;
        }
        #endregion
        #region Public Properties
        public virtual unknown Sig
        {
            get {return _sig;}
            set {_sig=value;}
        }
        public virtual int Ctime
        {
            get {return _ctime;}
            set {_ctime=value;}
        }
        public virtual string URI
        {
            get {return _URI;}
            set {_URI=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Fco
{
    #region Wp_wfnotifications
    public class Wp_wfnotifications
    {
        #region Member Variables
        protected string _id;
        protected bool _new;
        protected string _category;
        protected int _priority;
        protected int _ctime;
        protected string _html;
        protected string _links;
        #endregion
        #region Constructors
        public Wp_wfnotifications() { }
        public Wp_wfnotifications(bool new, string category, int priority, int ctime, string html, string links)
        {
            this._new=new;
            this._category=category;
            this._priority=priority;
            this._ctime=ctime;
            this._html=html;
            this._links=links;
        }
        #endregion
        #region Public Properties
        public virtual string Id
        {
            get {return _id;}
            set {_id=value;}
        }
        public virtual bool New
        {
            get {return _new;}
            set {_new=value;}
        }
        public virtual string Category
        {
            get {return _category;}
            set {_category=value;}
        }
        public virtual int Priority
        {
            get {return _priority;}
            set {_priority=value;}
        }
        public virtual int Ctime
        {
            get {return _ctime;}
            set {_ctime=value;}
        }
        public virtual string Html
        {
            get {return _html;}
            set {_html=value;}
        }
        public virtual string Links
        {
            get {return _links;}
            set {_links=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Fco
{
    #region Wp_wfpendingissues
    public class Wp_wfpendingissues
    {
        #region Member Variables
        protected int _id;
        protected int _time;
        protected string _status;
        protected string _type;
        protected bool _severity;
        protected string _ignoreP;
        protected string _ignoreC;
        protected string _shortMsg;
        protected string _longMsg;
        protected string _data;
        #endregion
        #region Constructors
        public Wp_wfpendingissues() { }
        public Wp_wfpendingissues(int time, string status, string type, bool severity, string ignoreP, string ignoreC, string shortMsg, string longMsg, string data)
        {
            this._time=time;
            this._status=status;
            this._type=type;
            this._severity=severity;
            this._ignoreP=ignoreP;
            this._ignoreC=ignoreC;
            this._shortMsg=shortMsg;
            this._longMsg=longMsg;
            this._data=data;
        }
        #endregion
        #region Public Properties
        public virtual int Id
        {
            get {return _id;}
            set {_id=value;}
        }
        public virtual int Time
        {
            get {return _time;}
            set {_time=value;}
        }
        public virtual string Status
        {
            get {return _status;}
            set {_status=value;}
        }
        public virtual string Type
        {
            get {return _type;}
            set {_type=value;}
        }
        public virtual bool Severity
        {
            get {return _severity;}
            set {_severity=value;}
        }
        public virtual string IgnoreP
        {
            get {return _ignoreP;}
            set {_ignoreP=value;}
        }
        public virtual string IgnoreC
        {
            get {return _ignoreC;}
            set {_ignoreC=value;}
        }
        public virtual string ShortMsg
        {
            get {return _shortMsg;}
            set {_shortMsg=value;}
        }
        public virtual string LongMsg
        {
            get {return _longMsg;}
            set {_longMsg=value;}
        }
        public virtual string Data
        {
            get {return _data;}
            set {_data=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Fco
{
    #region Wp_wfreversecache
    public class Wp_wfreversecache
    {
        #region Member Variables
        protected unknown _IP;
        protected string _host;
        protected int _lastUpdate;
        #endregion
        #region Constructors
        public Wp_wfreversecache() { }
        public Wp_wfreversecache(string host, int lastUpdate)
        {
            this._host=host;
            this._lastUpdate=lastUpdate;
        }
        #endregion
        #region Public Properties
        public virtual unknown IP
        {
            get {return _IP;}
            set {_IP=value;}
        }
        public virtual string Host
        {
            get {return _host;}
            set {_host=value;}
        }
        public virtual int LastUpdate
        {
            get {return _lastUpdate;}
            set {_lastUpdate=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Fco
{
    #region Wp_wfscanners
    public class Wp_wfscanners
    {
        #region Member Variables
        protected int _eMin;
        protected unknown _IP;
        protected unknown _hits;
        #endregion
        #region Constructors
        public Wp_wfscanners() { }
        public Wp_wfscanners(unknown hits)
        {
            this._hits=hits;
        }
        #endregion
        #region Public Properties
        public virtual int EMin
        {
            get {return _eMin;}
            set {_eMin=value;}
        }
        public virtual unknown IP
        {
            get {return _IP;}
            set {_IP=value;}
        }
        public virtual unknown Hits
        {
            get {return _hits;}
            set {_hits=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Fco
{
    #region Wp_wfsnipcache
    public class Wp_wfsnipcache
    {
        #region Member Variables
        protected int _id;
        protected string _IP;
        protected unknown _expiration;
        protected string _body;
        protected int _count;
        protected int _type;
        #endregion
        #region Constructors
        public Wp_wfsnipcache() { }
        public Wp_wfsnipcache(string IP, unknown expiration, string body, int count, int type)
        {
            this._IP=IP;
            this._expiration=expiration;
            this._body=body;
            this._count=count;
            this._type=type;
        }
        #endregion
        #region Public Properties
        public virtual int Id
        {
            get {return _id;}
            set {_id=value;}
        }
        public virtual string IP
        {
            get {return _IP;}
            set {_IP=value;}
        }
        public virtual unknown Expiration
        {
            get {return _expiration;}
            set {_expiration=value;}
        }
        public virtual string Body
        {
            get {return _body;}
            set {_body=value;}
        }
        public virtual int Count
        {
            get {return _count;}
            set {_count=value;}
        }
        public virtual int Type
        {
            get {return _type;}
            set {_type=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Fco
{
    #region Wp_wfstatus
    public class Wp_wfstatus
    {
        #region Member Variables
        protected unknown _id;
        protected unknown _ctime;
        protected bool _level;
        protected string _type;
        protected string _msg;
        #endregion
        #region Constructors
        public Wp_wfstatus() { }
        public Wp_wfstatus(unknown ctime, bool level, string type, string msg)
        {
            this._ctime=ctime;
            this._level=level;
            this._type=type;
            this._msg=msg;
        }
        #endregion
        #region Public Properties
        public virtual unknown Id
        {
            get {return _id;}
            set {_id=value;}
        }
        public virtual unknown Ctime
        {
            get {return _ctime;}
            set {_ctime=value;}
        }
        public virtual bool Level
        {
            get {return _level;}
            set {_level=value;}
        }
        public virtual string Type
        {
            get {return _type;}
            set {_type=value;}
        }
        public virtual string Msg
        {
            get {return _msg;}
            set {_msg=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Fco
{
    #region Wp_wfthrottlelog
    public class Wp_wfthrottlelog
    {
        #region Member Variables
        protected unknown _IP;
        protected int _startTime;
        protected int _endTime;
        protected int _timesThrottled;
        protected string _lastReason;
        #endregion
        #region Constructors
        public Wp_wfthrottlelog() { }
        public Wp_wfthrottlelog(int startTime, int endTime, int timesThrottled, string lastReason)
        {
            this._startTime=startTime;
            this._endTime=endTime;
            this._timesThrottled=timesThrottled;
            this._lastReason=lastReason;
        }
        #endregion
        #region Public Properties
        public virtual unknown IP
        {
            get {return _IP;}
            set {_IP=value;}
        }
        public virtual int StartTime
        {
            get {return _startTime;}
            set {_startTime=value;}
        }
        public virtual int EndTime
        {
            get {return _endTime;}
            set {_endTime=value;}
        }
        public virtual int TimesThrottled
        {
            get {return _timesThrottled;}
            set {_timesThrottled=value;}
        }
        public virtual string LastReason
        {
            get {return _lastReason;}
            set {_lastReason=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Fco
{
    #region Wp_wfvulnscanners
    public class Wp_wfvulnscanners
    {
        #region Member Variables
        protected unknown _IP;
        protected int _ctime;
        protected int _hits;
        #endregion
        #region Constructors
        public Wp_wfvulnscanners() { }
        public Wp_wfvulnscanners(int ctime, int hits)
        {
            this._ctime=ctime;
            this._hits=hits;
        }
        #endregion
        #region Public Properties
        public virtual unknown IP
        {
            get {return _IP;}
            set {_IP=value;}
        }
        public virtual int Ctime
        {
            get {return _ctime;}
            set {_ctime=value;}
        }
        public virtual int Hits
        {
            get {return _hits;}
            set {_hits=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Fco
{
    #region Wp_yoast_seo_links
    public class Wp_yoast_seo_links
    {
        #region Member Variables
        protected unknown _id;
        protected string _url;
        protected unknown _post_id;
        protected unknown _target_post_id;
        protected string _type;
        #endregion
        #region Constructors
        public Wp_yoast_seo_links() { }
        public Wp_yoast_seo_links(string url, unknown post_id, unknown target_post_id, string type)
        {
            this._url=url;
            this._post_id=post_id;
            this._target_post_id=target_post_id;
            this._type=type;
        }
        #endregion
        #region Public Properties
        public virtual unknown Id
        {
            get {return _id;}
            set {_id=value;}
        }
        public virtual string Url
        {
            get {return _url;}
            set {_url=value;}
        }
        public virtual unknown Post_id
        {
            get {return _post_id;}
            set {_post_id=value;}
        }
        public virtual unknown Target_post_id
        {
            get {return _target_post_id;}
            set {_target_post_id=value;}
        }
        public virtual string Type
        {
            get {return _type;}
            set {_type=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Fco
{
    #region Wp_yoast_seo_meta
    public class Wp_yoast_seo_meta
    {
        #region Member Variables
        protected unknown _object_id;
        protected int _internal_link_count;
        protected int _incoming_link_count;
        #endregion
        #region Constructors
        public Wp_yoast_seo_meta() { }
        public Wp_yoast_seo_meta(int internal_link_count, int incoming_link_count)
        {
            this._internal_link_count=internal_link_count;
            this._incoming_link_count=incoming_link_count;
        }
        #endregion
        #region Public Properties
        public virtual unknown Object_id
        {
            get {return _object_id;}
            set {_object_id=value;}
        }
        public virtual int Internal_link_count
        {
            get {return _internal_link_count;}
            set {_internal_link_count=value;}
        }
        public virtual int Incoming_link_count
        {
            get {return _incoming_link_count;}
            set {_incoming_link_count=value;}
        }
        #endregion
    }
    #endregion
}