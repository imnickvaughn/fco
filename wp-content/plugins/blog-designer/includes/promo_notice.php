<?php
add_action('plugins_loaded', 'bd_load_plugin');

if (!function_exists('bd_load_plugin')) {

    function bd_load_plugin() {

        // The promo time
        $blogDesigner['promo_time'] = get_option('blog_designer_promo_time');
        if (empty($blogDesigner['promo_time'])) {
            $blogDesigner['promo_time'] = time();
            update_option('blog_designer_promo_time', $blogDesigner['promo_time']);
        }

        // Are we to show the Blog Designer promo
        if (!empty($blogDesigner['promo_time']) && $blogDesigner['promo_time'] > 0 && $blogDesigner['promo_time'] < (time() - (60 * 60 * 24 * 3))) {
            add_action('admin_notices', 'blog_designer_promo');
        }

        // Are we to disable the promo
        if (isset($_GET['blog_designer_promo']) && (int) $_GET['blog_designer_promo'] == 0) {
            update_option('blog_designer_promo_time', (0 - time()));
            die('DONE');
        }
    }

}

if (!function_exists('blog_designer_promo')) {

    // Show the promo
    function blog_designer_promo() {
        echo '
            <script>
            jQuery(document).ready( function() {
                    (function($) {
                            $("#blog_designer_promo .blog_designer_promo-close").click(function(){
                                    var data;

                                    // Hide it
                                    $("#blog_designer_promo").hide();

                                    // Save this preference
                                    $.post("'.admin_url('?blog_designer_promo=0').'", data, function(response) {
                                            //alert(response);
                                    });
                            });
                    })(jQuery);
            });
            </script>
            <style>/* Promotional notice css*/
                .bd_button {
                    background-color: #4CAF50; /* Green */
                    border: none;
                    color: white;
                    padding: 8px 16px;
                    text-align: center;
                    text-decoration: none;
                    display: inline-block;
                    font-size: 16px;
                    margin: 4px 2px;
                    -webkit-transition-duration: 0.4s; /* Safari */
                    transition-duration: 0.4s;
                    cursor: pointer;
                }
                .bd_button:focus{
                    border: none;
                    color: white;
                }
                .bd_button1 {
                    color: white;
                    background-color: #4CAF50;
                    border:3px solid #4CAF50;
                }
                .bd_button1:hover {
                    box-shadow: 0 6px 8px 0 rgba(0,0,0,0.24), 0 9px 25px 0 rgba(0,0,0,0.19);
                    color: white;
                    border:3px solid #4CAF50;
                }
                .bd_button2 {
                    color: white;
                    background-color: #0085ba;
                }
                .bd_button2:hover {
                    box-shadow: 0 6px 8px 0 rgba(0,0,0,0.24), 0 9px 25px 0 rgba(0,0,0,0.19);
                    color: white;
                }
                .bd_button3 {
                    color: white;
                    background-color: #365899;
                }
                .bd_button3:hover {
                    box-shadow: 0 6px 8px 0 rgba(0,0,0,0.24), 0 9px 25px 0 rgba(0,0,0,0.19);
                    color: white;
                }
                .bd_button4 {
                    color: white;
                    background-color: rgb(66, 184, 221);
                }
                .bd_button4:hover {
                    box-shadow: 0 6px 8px 0 rgba(0,0,0,0.24), 0 9px 25px 0 rgba(0,0,0,0.19);
                    color: white;
                }
                .blog_designer_promo-close {
                    float:right;
                    text-decoration:none;
                    margin: 5px 10px 0px 0px;
                }
                .blog_designer_promo-close:hover {
                    color: red;
                }
                </style>
                <div class="notice notice-success" id="blog_designer_promo" style="min-height:120px">
                        <a class="blog_designer_promo-close" href="javascript:" aria-label="Dismiss this Notice">
                                <span class="dashicons dashicons-dismiss"></span> Dismiss
                        </a>
                        <img src="' . BLOGDESIGNER_URL . '/images/blog-designer-200.png" style="float:left; margin:10px 20px 10px 10px" width="100" />
                        <p style="font-size:16px">' . __("We are glad you like Blog Designer and have been using it since the past few days. It is time to take the next step", "blog-designer") . '</p>
                        <p>
                                <a class="bd_button bd_button1" target="_blank" href="http://blogdesigner.solwininfotech.com/pricing/#ptp-816">Upgrade to Pro</a>
                                <a class="bd_button bd_button2" target="_blank" href="https://wordpress.org/support/plugin/blog-designer/reviews/?filter=5">Rate it 5★\'s</a>
                                <a class="bd_button bd_button3" target="_blank" href="https://www.facebook.com/SolwinInfotech/">Like Us on Facebook</a>
                                <a class="bd_button bd_button4" target="_blank" href="https://twitter.com/home?status=' . rawurlencode('I use #blogdesigner to design my #WordPress blog site - http://blogdesigner.solwininfotech.com') . '">Tweet about Blog Designer</a>
                        </p>
                </div>';
    }

}