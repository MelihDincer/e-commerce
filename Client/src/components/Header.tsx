import { ShoppingCart } from "@mui/icons-material";
import { AppBar, Badge, Box, Button, IconButton, Stack, Toolbar, Typography } from "@mui/material";
import { NavLink } from "react-router";

const links = [
    {title: "Home", to:"/"},
    {title: "Catalog", to:"/catalog"},
    {title: "About", to:"/about"},
    {title: "Contact", to:"/contact"},
    {title: "Error", to:"/error"}
]

const navStyles = {
    color:"inherit",
    textDecoration: "none",
    "&:hover": {
        color:"text-primary"
    },
    "&.active": {
        color: "warning.main"
    }
}
function Header() {
    return(
        <AppBar position="static" sx={{mb:1}}>
            <Toolbar sx={{display:"flex", justifyContent:"space-between"}}>
                <Box sx={{display:"flex", alignItems:"center"}}>
                    <Typography variant="h6">E Commerce</Typography>
                    <Stack direction="row">
                        {links.map(link => 
                        <Button key={link.to} component={NavLink} to={link.to} sx={navStyles}>{link.title}</Button>
                    )}
                    </Stack>
                    {/* <List sx={{display:"flex"}}>
                        {links.map(link => 
                        <ListItem component={NavLink} to={link.to} sx={navStyles}>{link.title}</ListItem>
                    )}
                    </List> */}
                </Box>
                <Box>
                    <IconButton size="large" edge="start" color="inherit">
                        <Badge badgeContent="2" color="secondary">
                            <ShoppingCart/>
                        </Badge>
                    </IconButton>
                </Box>
                
            </Toolbar>
        </AppBar>
    );
  }

  export default Header;