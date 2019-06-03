<?php
/**
 * The base configuration for WordPress
 *
 * The wp-config.php creation script uses this file during the
 * installation. You don't have to use the web site, you can
 * copy this file to "wp-config.php" and fill in the values.
 *
 * This file contains the following configurations:
 *
 * * MySQL settings
 * * Secret keys
 * * Database table prefix
 * * ABSPATH
 *
 * @link https://codex.wordpress.org/Editing_wp-config.php
 *
 * @package WordPress
 */

// ** MySQL settings - You can get this info from your web host ** //
/** The name of the database for WordPress */
define('DB_NAME', 'regenesi_regen');

/** MySQL database username */
define('DB_USER', 'regenesi_db');

/** MySQL database password */
define('DB_PASSWORD', 'regenesismeditech@123');

/** MySQL hostname */
define('DB_HOST', 'localhost');

/** Database Charset to use in creating database tables. */
define('DB_CHARSET', 'utf8mb4');

/** The Database Collate type. Don't change this if in doubt. */
define('DB_COLLATE', '');

/**#@+
 * Authentication Unique Keys and Salts.
 *
 * Change these to different unique phrases!
 * You can generate these using the {@link https://api.wordpress.org/secret-key/1.1/salt/ WordPress.org secret-key service}
 * You can change these at any point in time to invalidate all existing cookies. This will force all users to have to log in again.
 *
 * @since 2.6.0
 */
define('AUTH_KEY',         '/ooK(Fug-GCQ|)+y4biFOK%k5}x1hYQHOn!U%3eq*igI:XRa-/;?NJ9!T7/9p*_d');
define('SECURE_AUTH_KEY',  'xw^F~$,VYy~0G|pLwxZ#}dnL7k<Ey}R;Q6*0&NtR#^9cSJF!Gc2o|l1Tl{KPu$NG');
define('LOGGED_IN_KEY',    'Zo|);~;}XS;T!RG:>3a|HPbO])ax/gK<&?/^~c|qM!i%QH@0F^yLJ ~3 yR${$Z)');
define('NONCE_KEY',        'ngqOf.B/au&I1F%4Xpk5U;*k%7GGt{**_Cm18JsW>pdBz_rJ8P[3<Mic_y@Hb5=,');
define('AUTH_SALT',        'Thp0wd2t#+BMxYVv /G8m*!DM?.u*:L5$}x50So)AZ#VV}NJd^7[%y+y:]oa3G;}');
define('SECURE_AUTH_SALT', 'Mi<e/){B<6)~mCGE22[[Dh}6W5aW2e c]Zt/{s8M|_$ne$E.%a{?U@m7zvyP9j|8');
define('LOGGED_IN_SALT',   'X,1iP#cP1:XWWdo}GhLE;/jB[H-YW7-=Fe}a26G^Y<zF=)o4W}F:HkiR[z[jMV%C');
define('NONCE_SALT',       '$PS3yMQ!tz8s3;MZ6r,*_b%IXE %Ks~Y|rW$Y/eG/2avp3~U(PKTY::#P*Lq0.f[');

/**#@-*/

/**
 * WordPress Database Table prefix.
 *
 * You can have multiple installations in one database if you give each
 * a unique prefix. Only numbers, letters, and underscores please!
 */
$table_prefix  = 'wp_';

/**
 * For developers: WordPress debugging mode.
 *
 * Change this to true to enable the display of notices during development.
 * It is strongly recommended that plugin and theme developers use WP_DEBUG
 * in their development environments.
 *
 * For information on other constants that can be used for debugging,
 * visit the Codex.
 *
 * @link https://codex.wordpress.org/Debugging_in_WordPress
 */
 
error_reporting(E_ALL); ini_set('display_errors', 1);
 
define('WP_DEBUG', true);

define( 'WP_MEMORY_LIMIT', '512M' );

/* That's all, stop editing! Happy blogging. */

/** Absolute path to the WordPress directory. */
if ( !defined('ABSPATH') )
	define('ABSPATH', dirname(__FILE__) . '/');

/** Sets up WordPress vars and included files. */
require_once(ABSPATH . 'wp-settings.php');
