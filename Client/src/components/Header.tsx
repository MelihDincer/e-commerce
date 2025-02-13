import { AppBar, Container, Toolbar, Typography } from "@mui/material";

function Header() {
    return(
        <AppBar position="static" sx={{mb:1}}>
            <Toolbar>
                <Container>
                    <Typography variant="h6">E Commerce</Typography>
                </Container>
            </Toolbar>
        </AppBar>
    );
  }

  export default Header;